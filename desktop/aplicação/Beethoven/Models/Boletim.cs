using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Models
{
    public class Boletim
    {
        // relacionamentos
        public virtual Aluno Aluno { get; set; }
        public virtual Curso Curso { get; set; }
        // chaves
        public uint Id { get; set; }
        public uint AlunoId { get; set; }
        public ushort CursoId { get; set; }
        // atributos
        DateTime Publicacao { get; set; }
        float Media01 { get; set; }
        float Media02 { get; set; }
        float Media03 { get; set; }
        float Media04 { get; set; }
        float MediaFinal { get; set; }
        float Recuperacao { get; set; }
    }
}