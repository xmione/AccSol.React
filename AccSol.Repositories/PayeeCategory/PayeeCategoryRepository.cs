using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class PayeeCategoryRepository : RepositoryBase<PayeeCategory>, IPayeeCategoryRepository
    {
        public PayeeCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<PayeeCategory> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public PayeeCategory? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
        public void DeletePayeeCategory(PayeeCategory payeeCategory) => Delete(payeeCategory);
        public PayeeCategory? SavePayeeCategory(PayeeCategory payeeCategory)
        {
            // checked if it is a new entry
            if (payeeCategory.ID == 0)
            {
                //if it is, check the name if it exists
                var foundName = GetAll(trackChanges: false).Where(n => n.Name.Contains(payeeCategory.Name.Trim())).FirstOrDefault();
                if (foundName != null)
                {
                    payeeCategory = Update(payeeCategory);
                }
                else 
                {
                    payeeCategory = Create(payeeCategory);
                }
            }
            else 
            {
                //if it is not a new entry update
                payeeCategory = Update(payeeCategory);
            }

            return payeeCategory;
        }
    }
}