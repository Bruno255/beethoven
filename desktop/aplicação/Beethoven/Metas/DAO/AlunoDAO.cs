using Beethoven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Metas.DAO
{
    public class AlunoDAO
    {
        // contexto de dados
        private ModelContext contexto = new ModelContext();

        // cadastrar um aluno
        public void Cadastrar(Aluno aluno)
        {
            contexto.Aluno.Add(aluno);
            contexto.SaveChanges();
        }

        // exibir todos os alunos
        public List<Aluno> Visualizar()
        {
            IQueryable<Aluno> alunos = from aln in contexto.Aluno select aln;
            return alunos.ToList();
        }
    }
}