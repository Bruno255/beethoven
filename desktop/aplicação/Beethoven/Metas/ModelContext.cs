using Beethoven.Models;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Beethoven.Metas
{
    public class ModelContext : DbContext
    {
        // estruturas de dados
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Botetim> Boletins { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        // configuração de conexão
    }
}