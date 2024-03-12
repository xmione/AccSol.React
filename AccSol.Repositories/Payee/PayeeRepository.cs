using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class PayeeRepository : RepositoryBase<Payee>, IPayeeRepository
    {
        public PayeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Payee> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public Payee? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();

        public void DeletePayee(Payee payee) => Delete(payee);
        public Payee? SavePayee(Payee payee)
        {
            var foundPayee = Get(payee.ID, trackChanges: false);
            if (foundPayee != null)
            {
                Update(payee);
            }
            else
            {
                Create(payee);
            }

            return foundPayee;
        }
    }
}