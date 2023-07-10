using EternaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaApp
{
    public class EternaDbContext:DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options):base(options)
        {
            
        }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<Service>? Services { get; set; }

    }
}
