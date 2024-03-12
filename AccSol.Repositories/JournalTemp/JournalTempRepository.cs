using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class JournalTempRepository : RepositoryBase<JournalTemp>, IJournalTempRepository
    {
        public JournalTempRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<JournalTemp> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public JournalTemp? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
        public void DeleteJournalTemp(JournalTemp journalTemp) => Delete(journalTemp);
        public JournalTemp? SaveJournalTemp(JournalTemp journalTemp)
        {
            var foundJournalTemp = Get(journalTemp.ID, trackChanges: false);
            if (foundJournalTemp != null)
            {
                Update(journalTemp);
            }
            else
            {
                Create(journalTemp);
            }

            return foundJournalTemp;
        }
    }
}