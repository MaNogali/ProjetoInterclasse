using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProjetoInterclasse.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Chaveamento> Chaveamentos { get; set; }
        public DbSet<Classificacao> Classificacoes { get; set; }
        public DbSet<Partida> Partidas { get; set; }
    }
}