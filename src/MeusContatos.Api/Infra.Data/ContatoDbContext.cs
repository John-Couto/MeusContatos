using MeusContatos.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeusContatos.Api.Infra.Data
{
    public class ContatoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=mysecretpassword;Host=localhost;Port=5432;Database=postgres;Pooling=true;");
        }        

        public DbSet<Contato>? Contatos { get; set; }
    }

}
