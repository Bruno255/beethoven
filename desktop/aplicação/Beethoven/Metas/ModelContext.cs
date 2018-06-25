using Beethoven.Models;
using Microsoft.Data.Entity;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beethoven.Metas
{
    public class ModelContext : DbContext
    {
        // estruturas de dados
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Boletim> Boletim { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        // configuração de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = ConfigurationManager.ConnectionStrings[""].ConnectionString; // configurar string de conexão
            optionsBuilder.UseSqlServer(conexao);                                         // alterar para MySQL
            base.OnConfiguring(optionsBuilder);
        }
    }
}