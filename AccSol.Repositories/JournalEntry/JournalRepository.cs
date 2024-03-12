using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class JournalRepository : RepositoryBase<Journal>, IJournalRepository
    {
        public JournalRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Journal> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public Journal? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
        public void DeleteJournal(Journal journal) => Delete(journal);
        public Journal? SaveJournal(Journal journal)
        {
            var foundJournal = Get(journal.ID, trackChanges: false);
            if (foundJournal != null)
            {
                Update(journal);
            }
            else
            {
                Create(journal);
            }

            return foundJournal;
        }
    }
}