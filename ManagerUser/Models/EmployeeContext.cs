using Microsoft.EntityFrameworkCore;

namespace ManagerUser.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
    }
}
