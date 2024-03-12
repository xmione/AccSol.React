using AccSol.Models;

namespace AccSol.Repositories
{
    public interface ICoaRepository
    {
        IEnumerable<Coa> GetAll(bool trackChanges);
        Coa? Get(int? id, bool trackChanges);
        void DeleteCoa(Coa coa);
        Coa? SaveCoa(Coa coa);
    }
}
