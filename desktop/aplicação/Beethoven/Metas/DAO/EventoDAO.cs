using Beethoven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Metas.DAO
{
    public class EventoDAO
    {
        // contexto de dados
        private ModelContext contexto = new ModelContext();

        // cadastrar um evento
        public void Cadastrar(Evento evento)
        {
            contexto.Evento.Add(evento);
            contexto.SaveChanges();
        }

        // exibir todos os eventos
        public List<Evento> Visualizar()
        {
            IQueryable<Evento> eventos = from evn in contexto.Evento select evn;
            return eventos.ToList();
        }
    }
}