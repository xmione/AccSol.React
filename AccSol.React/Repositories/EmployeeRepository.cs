using AccSol.React.Contracts;
using AccSol.React.Entities.Contexts;
using AccSol.React.Entities.Models;

namespace AccSol.React.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly ApplicationContext _context;
        public EmployeeRepository(ApplicationContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll() => _context.Employees.ToList();
    }
}
