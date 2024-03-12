using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IProjectCategoryRepository
    {
        IEnumerable<ProjectCategory> GetAll(bool trackChanges);
        ProjectCategory? Get(int? id, bool trackChanges);
        void DeleteProjectCategory(ProjectCategory projectCategory);
        ProjectCategory? SaveProjectCategory(ProjectCategory projectCategory);
    }
}
