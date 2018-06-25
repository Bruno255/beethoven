using Beethoven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Metas.DAO
{
    public class ColaboradorDAO
    {
        // contexto de dados
        private ModelContext contexto = new ModelContext();

        // cadastrar um colaborador
        public void Cadastrar(Colaborador colaborador)
        {
            contexto.Colaborador.Add(colaborador);
            contexto.SaveChanges();
        }

        // exibir todos os colaboradores
        public List<Colaborador> Visualizar()
        {
            IQueryable<Colaborador> colaboradores = from clb in contexto.Colaborador select clb;
            return colaboradores.ToList();
        }
    }
}