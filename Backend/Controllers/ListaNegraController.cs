using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaNegraController : ControllerBase
    {
        Business.ListaNegraBusiness bs = new Business.ListaNegraBusiness();
        Utils.ListaNegraConversor conv = new Utils.ListaNegraConversor();

       
        [HttpPost]
        public ActionResult<Models.Response.ListaNegraResponse> Inserir(Models.Request.ListaNegraRequest request)
        {
            try
            {
                Models.TbListaNegra ln = conv.ParaTabela(request);                
                bs.Salvar(ln);

                Models.Response.ListaNegraResponse resp = conv.ParaResponse(ln);

                return resp;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }

        [HttpGet]
        public ActionResult<List<Models.Response.ListaNegraResponse>> Lista(Models.TbListaNegra request)
        {
            try
            {
                List<Models.TbListaNegra> lns = bs.Listar();
                if(lns.Count == 0)
                return NotFound();

                List<Models.Response.ListaNegraResponse> resp = conv.ParaResponse(lns);
                return resp;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(500, ex.Message)
                );
            }

        }

    }

}