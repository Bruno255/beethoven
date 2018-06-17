using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Models
{
    public abstract class Pessoa
    {
        // chave
        public uint Id { get; set; }
        // atributos
        char Acesso { get; set; }
        string Celular { get; set; }
        string CPF { get; set; }
        string Email { get; set; }
        string Nome { get; set; }
        string Senha { get; set; }
        string Telefone { get; set; }
        string Usuario { get; set; }
    }
}