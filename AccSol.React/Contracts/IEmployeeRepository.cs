using AccSol.React.Entities.Models;

namespace AccSol.React.Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
    }
}
