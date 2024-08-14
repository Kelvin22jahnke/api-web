using AgendaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AgendaAPI.Infraestrutura.DB
{
    public class ConexaoContext : DbContext
    {
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;User Id=root;Password=;Database=agenda");
            }
        }

    }
}
