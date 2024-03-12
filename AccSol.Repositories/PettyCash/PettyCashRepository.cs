using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class PettyCashRepository : RepositoryBase<PettyCash>, IPettyCashRepository
    {
        public PettyCashRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<PettyCash> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public PettyCash? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();

        public void DeletePettyCash(PettyCash pettyCash) => Delete(pettyCash);
        public PettyCash? SavePettyCash(PettyCash pettyCash)
        {
            var foundPettyCash = Get(pettyCash.ID, trackChanges: false);
            if (foundPettyCash != null)
            {
                Update(pettyCash);
            }
            else
            {
                Create(pettyCash);
            }

            return foundPettyCash;
        }
    }
}