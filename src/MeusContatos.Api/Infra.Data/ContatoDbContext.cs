using MeusContatos.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeusContatos.Api.Infra.Data
{
    public class ClasseGeraldbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=12345678;Host=localhost;Port=5432;Database=postgres;Pooling=true;");
        }        

        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<SuperHeroi>? SuperHeroi { get; set; }
    }

}
