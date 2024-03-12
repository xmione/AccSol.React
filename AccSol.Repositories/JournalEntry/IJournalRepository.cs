using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IJournalRepository
    {
        IEnumerable<Journal> GetAll(bool trackChanges);
        Journal? Get(int? id, bool trackChanges);
        void DeleteJournal(Journal journal);
        Journal? SaveJournal(Journal journal);
    }
}
