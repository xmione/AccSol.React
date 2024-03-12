using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Department> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public Department? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
               
        public void DeleteDepartment(Department department) => Delete(department);
        public Department? SaveDepartment(Department department)
        {
            var foundDepartment = Get(department.ID, trackChanges: false);
            if (foundDepartment != null)
            {
                Update(department);
            }
            else
            {
                Create(department);
            }

            return foundDepartment;
        }
    }
}