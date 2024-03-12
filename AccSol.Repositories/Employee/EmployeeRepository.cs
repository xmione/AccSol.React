using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Employee> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public Employee? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();

        public void DeleteEmployee(Employee employee) => Delete(employee);
        public Employee? SaveEmployee(Employee employee)
        {
            var foundEmployee = Get(employee.ID, trackChanges: false);
            if (foundEmployee != null)
            {
                Update(employee);
            }
            else
            {
                Create(employee);
            }

            return foundEmployee;
        }
    }
}