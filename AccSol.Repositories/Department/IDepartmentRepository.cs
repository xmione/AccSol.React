using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll(bool trackChanges);
        Department? Get(int? id, bool trackChanges);
        void DeleteDepartment(Department department);
        Department? SaveDepartment(Department department);
    }
}
