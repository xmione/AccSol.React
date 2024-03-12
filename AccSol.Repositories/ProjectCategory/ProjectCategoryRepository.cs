using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class ProjectCategoryRepository : RepositoryBase<ProjectCategory>, IProjectCategoryRepository
    {
        public ProjectCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<ProjectCategory> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public ProjectCategory? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
               
        public void DeleteProjectCategory(ProjectCategory projectCategory) => Delete(projectCategory);
        public ProjectCategory? SaveProjectCategory(ProjectCategory projectCategory)
        {
            var foundProjectCategory = Get(projectCategory.ID, trackChanges: false);
            if (foundProjectCategory != null)
            {
                Update(projectCategory);
            }
            else
            {
                Create(projectCategory);
            }

            return foundProjectCategory;
        }
    }
}