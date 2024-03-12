using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IPayeeRepository
    {
        IEnumerable<Payee> GetAll(bool trackChanges);
        Payee? Get(int? id, bool trackChanges);
        void DeletePayee(Payee payee);
        Payee? SavePayee(Payee payee);
    }
}
