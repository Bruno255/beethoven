using Beethoven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Metas.DAO
{
    public class Boletim
    {
        // contexto de dados
        private ModelContext contexto = new ModelContext();

        // cadastrar um boletim
        public void Cadastrar(Boletim boletim)
        {
            contexto.Boletim.Add(boletim);
            contexto.SaveChanges();
        }
    }
}