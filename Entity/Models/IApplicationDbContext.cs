using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Entity.Models
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        Task<int> SaveChanges();
    }

}
