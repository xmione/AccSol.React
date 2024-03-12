using AccSol.React.Contracts;
using AccSol.React.Entities.Contexts;
using AccSol.React.Entities.Models;

namespace AccSol.React.Repositories
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly ApplicationContext _context;
        public DepartmentRepository(ApplicationContext context)
        {
            _context = context;
        }
        public IEnumerable<Department> GetAll() => _context.Departments.ToList();
    }
}
