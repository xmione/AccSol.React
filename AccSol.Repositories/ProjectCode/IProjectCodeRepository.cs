using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IProjectCodeRepository
    {
        IEnumerable<ProjectCode> GetAll(bool trackChanges);
        ProjectCode? Get(int? id, bool trackChanges);
        void DeleteProjectCode(ProjectCode projectCode);
        ProjectCode? SaveProjectCode(ProjectCode projectCode);
    }
}
