using AccSol.React.Entities.Models;

namespace AccSol.React.Contracts
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
    }
}
