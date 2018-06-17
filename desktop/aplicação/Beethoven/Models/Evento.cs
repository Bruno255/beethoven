using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Models
{
    public class Evento
    {
        // relacionamentos
        public virtual Colaborador Responsavel { get; set; }
        // chaves
        public uint Id { get; set; }
        public uint ResponsavelId { get; set; }
        // atributos
        DateTime Realizacao { get; set; }
        string Descricao { get; set; }
        byte Inicio { get; set; }
        byte Termino { get; set; }
        string Titulo { get; set; }
        string Local { get; set; }
        string Publico { get; set; }
    }
}