using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll(bool trackChanges);
        Employee? Get(int? id, bool trackChanges);
        void DeleteEmployee(Employee employee);
        Employee? SaveEmployee(Employee employee);
    }
}
