using InventarioServidores.Models;
using Microsoft.EntityFrameworkCore;


namespace InventarioServidores.Datos
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Servidores> Servidores { get; set; } = default!;

    }
}
