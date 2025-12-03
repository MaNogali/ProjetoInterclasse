using System.Collections.Generic;
using System.Data.Entity;

namespace ProjetoInterclasse.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            base ("Server=localhost;database=dbInterclasse;user=root;password=12345678")
          {
            }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Time> Time { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Chaveamento> Chaveamento { get; set; }
        public DbSet<Classificacao> Classificassao { get; set; }
        public DbSet<Partida> Partida { get; set; }
    }
}
