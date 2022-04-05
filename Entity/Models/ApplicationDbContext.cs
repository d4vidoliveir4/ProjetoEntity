using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){  }
        public DbSet<Employee> Employees { get; set; }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
