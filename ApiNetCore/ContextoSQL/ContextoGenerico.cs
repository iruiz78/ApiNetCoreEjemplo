using Microsoft.EntityFrameworkCore;
using WebApplication9.Modelos;

namespace WebApplication9.ContextoSQL
{
    public class ContextoGenerico : DbContext
    {
        public ContextoGenerico(DbContextOptions<ContextoGenerico> options) : base(options)
        {}

        public DbSet<Cliente> clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
        }

    }
}
