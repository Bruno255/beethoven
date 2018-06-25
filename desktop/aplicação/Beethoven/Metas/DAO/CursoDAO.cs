using Beethoven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Metas.DAO
{
    public class CursoDAO
    {
        // contexto de dados
        private ModelContext contexto = new ModelContext();

        // cadastrar um curso
        public void Cadastrar(Curso curso)
        {
            contexto.Curso.Add(curso);
            contexto.SaveChanges();
        }

        // exibir todos os cursos
        public List<Curso> Visualizar()
        {
            IQueryable<Curso> cursos = from crs in contexto.Curso select crs;
            return cursos.ToList();
        }
    }
}