using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class ProjectCodeRepository : RepositoryBase<ProjectCode>, IProjectCodeRepository
    {
        public ProjectCodeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<ProjectCode> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public ProjectCode? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
               
        public void DeleteProjectCode(ProjectCode projectCode) => Delete(projectCode);
        public ProjectCode? SaveProjectCode(ProjectCode projectCode)
        {
            var foundProjectCode = Get(projectCode.ID, trackChanges: false);
            if (foundProjectCode != null)
            {
                Update(projectCode);
            }
            else
            {
                Create(projectCode);
            }

            return foundProjectCode;
        }
    }
}