using Eye.Team.AcessoDadosEntity.TypeConfiguration;
using Eye.Team.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.AcessoDadosEntity.Contexto
{
    public class EyeTeamDbContext : DbContext
    {
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Jogo> Jogos { get; set; }

        public EyeTeamDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EstadoTypeConfiguration());
            modelBuilder.Configurations.Add(new CidadeTypeConfiguration());
            modelBuilder.Configurations.Add(new TimeTypeConfiguration());
            modelBuilder.Configurations.Add(new JogadorTypeConfiguration());
            modelBuilder.Configurations.Add(new JogoTypeConfiguration());
        }
    }
}
