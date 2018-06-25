using Beethoven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Metas.DAO
{
    public class AulaDAO
    {
        // contexto de dados
        private ModelContext contexto = new ModelContext();

        // cadastrar uma aula
        public void Cadastrar(Aula aula)
        {
            contexto.Aula.Add(aula);
            contexto.SaveChanges();
        }

        // exibir todas as aulas
        public List<Aula> Visualizar()
        {
            IQueryable<Aula> aulas = from als in contexto.Aula select als;
            return aulas.ToList();
        }
    }
}