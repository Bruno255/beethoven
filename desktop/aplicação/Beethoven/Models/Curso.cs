using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Models
{
    public class Curso
    {
        // relacionamentos
        public virtual List<Aula> Aulas { get; set; }
        public virtual List<Boletim> Boletins { get; set; }
        // chave
        public ushort Id { get; set; }
        // atributos
        ushort CargaHoraria { get; set; }
        string Instrumento { get; set; }
        string Modelo { get; set; }
    }
}