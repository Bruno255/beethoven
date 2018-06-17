using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Models
{
    public class Colaborador : Pessoa
    {
        // relacionamentos
        public virtual List<Aula> Aulas { get; set; }
        public virtual List<Evento> Eventos { get; set; }
        // atributos
        DateTime Admissao { get; set; }
        string Profissao { get; set; }
        float Salario { get; set; }
    }
}