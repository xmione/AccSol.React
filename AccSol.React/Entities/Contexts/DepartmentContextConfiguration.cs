using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AccSol.React.Entities.Models;

namespace AccSol.React.Entities.Contexts
{
    public class DepartmentContextConfiguration : IEntityTypeConfiguration<Department>
    {
        private int[] _ids;

        public DepartmentContextConfiguration(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
              .HasData(
                new Department
                {
                    ID = _ids[0],
                    Code = "AGENT007",
                    Name = "James Bond",
                },
                new Department
                {
                    ID = _ids[1],
                    Code = "AGENT00",
                    Name = "Weng Weng",
                }
            );
        }
    }
}
