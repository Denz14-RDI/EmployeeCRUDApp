using Microsoft.EntityFrameworkCore;
using EmployeeCRUDApp.Models;

namespace EmployeeCRUDApp.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}