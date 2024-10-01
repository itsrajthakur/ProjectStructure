using Microsoft.EntityFrameworkCore;
using ProjectStructure.ViewModel;

namespace ProjectStructure.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}
