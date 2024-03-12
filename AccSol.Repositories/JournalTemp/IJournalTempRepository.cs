using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IJournalTempRepository
    {
        IEnumerable<JournalTemp> GetAll(bool trackChanges);
        JournalTemp? Get(int? id, bool trackChanges);
        void DeleteJournalTemp(JournalTemp journalTemp);
        JournalTemp? SaveJournalTemp(JournalTemp journalTemp);
    }
}
