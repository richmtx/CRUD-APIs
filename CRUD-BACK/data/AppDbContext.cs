using Microsoft.EntityFrameworkCore;

namespace CRUD_BACK.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Aquí irán tus tablas
        // Ejemplo:
        // public DbSet<Usuario> Usuarios { get; set; }
    }
}