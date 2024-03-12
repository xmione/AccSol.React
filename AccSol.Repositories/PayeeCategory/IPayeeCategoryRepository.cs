using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IPayeeCategoryRepository
    {
        IEnumerable<PayeeCategory> GetAll(bool trackChanges);
        PayeeCategory? Get(int? id, bool trackChanges);
        void DeletePayeeCategory(PayeeCategory payeeCategory);
        PayeeCategory? SavePayeeCategory(PayeeCategory payeeCategory);
    }
}
