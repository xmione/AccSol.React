using AccSol.React.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Principal;

namespace AccSol.React.Entities.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = new int[] { 1, 2 };

            modelBuilder.ApplyConfiguration(new EmployeeContextConfiguration(ids));
            modelBuilder.ApplyConfiguration(new DepartmentContextConfiguration(ids));
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
