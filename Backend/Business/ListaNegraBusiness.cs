using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Backend.Business
{
    public class ListaNegraBusiness
    {
       Database.ListaNegraDatabase ctx = new Database.ListaNegraDatabase();

        public Models.TbListaNegra Salvar(Models.TbListaNegra ln)
        {
            if(ln.NmPessoa == string.Empty)
            throw new Exception("Nome é inválido!");

            if(ln.NmPessoa == string.Empty)
            throw new Exception("Motivo está vazio!");

            return ctx.Salvar(ln);
        }

        public List<Models.TbListaNegra> Listar()
        {
            return ctx.Listar();
        }
    }
}