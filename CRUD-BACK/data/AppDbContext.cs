using Microsoft.EntityFrameworkCore;
using CRUD_BACK.Models;

namespace CRUD_BACK.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Crud> CRUD { get; set; }
    }
}