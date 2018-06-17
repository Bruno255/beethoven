using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Models
{
    public class Aula
    {
        // relacionamentos
        public virtual Curso Curso { get; set; }
        public virtual Colaborador Professor { get; set; }
        // chaves
        public uint Id { get; set; }
        public ushort CursoId { get; set; }
        public uint ProfessorId { get; set; }
        // atributos
        DateTime Realizacao { get; set; }
        string Modelo { get; set; }
    }
}