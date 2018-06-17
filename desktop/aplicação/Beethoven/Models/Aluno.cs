using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Models
{
    public class Aluno : Pessoa
    {
        // relacionamento
        public virtual List<Botetim> Boletins { get; set; }
        // atributos
        bool Cursando { get; set; }
        DateTime Matricula { get; set; }
        string Numero { get; set; }
    }
}