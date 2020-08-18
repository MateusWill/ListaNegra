using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database
{
    public class ListaNegraDatabase
    {
         Models.lndbContext ctx = new Models.lndbContext();

        public Models.TbListaNegra Salvar(Models.TbListaNegra ln)
        {
            
            ctx.Add(ln);
            ctx.SaveChanges();

            return ln;
        }

        public List<Models.TbListaNegra> Listar()
        {
            List<Models.TbListaNegra> lns = ctx.TbListaNegra.ToList();
            return lns;
        }
    }
}