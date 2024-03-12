using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class CoaRepository : RepositoryBase<Coa>, ICoaRepository
    {
        public CoaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Coa> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public Coa? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
        public void DeleteCoa(Coa coa) => Delete(coa);
        public Coa? SaveCoa(Coa coa)
        {
            var foundCoa = Get(coa.ID, trackChanges: false);
            if (foundCoa != null)
            {
                Update(coa);
            }
            else
            {
                Create(coa);
            }

            return foundCoa;
        }
    }
}