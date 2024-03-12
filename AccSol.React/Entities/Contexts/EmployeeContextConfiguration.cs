using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AccSol.React.Entities.Models;

namespace AccSol.React.Entities.Contexts
{
    public class EmployeeContextConfiguration : IEntityTypeConfiguration<Employee>
    {
        private int[] _ids;

        public EmployeeContextConfiguration(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
              .HasData(
                new Employee
                {
                    ID = _ids[0],
                    EmployeeNumber = _ids[0].ToString(),
                    FirstName = "Bat",
                    MiddleName = "Na",
                    LastName = "Man",
                    DepartmentID = _ids[0],
                },
                new Employee
                {
                    ID = _ids[1],
                    EmployeeNumber = _ids[1].ToString(),
                    FirstName = "Super",
                    MiddleName = "Duper", //Dooper is a reserved word
                    LastName = "Man",
                    DepartmentID = _ids[1],
                }
            );
        }
    }
}
