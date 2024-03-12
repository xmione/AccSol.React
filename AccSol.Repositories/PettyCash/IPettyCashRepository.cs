using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IPettyCashRepository
    {
        IEnumerable<PettyCash> GetAll(bool trackChanges);
        PettyCash? Get(int? id, bool trackChanges);
        void DeletePettyCash(PettyCash pettyCash);
        PettyCash? SavePettyCash(PettyCash pettyCash);
    }
}
