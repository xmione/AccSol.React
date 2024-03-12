using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class CoaVM : Coa, IValidatableObject, ICloneable<CoaVM>, IViewModel<Coa, CoaVM>
    {
        private List<Coa> _coas = new List<Coa>(); // Initialize the list
        public bool IsEditing { get; set; } // Boolean property to indicate editing mode
        public CoaVM() { }
        public CoaVM(Coa coa)
        {
            ID = coa.ID;
            Category = coa.Category;
            SubCategory = coa.SubCategory;
            AccountName = coa.AccountName;
        }
        public CoaVM Clone()
        {
            return new CoaVM
            {
                ID = this.ID,
                Category = this.Category,
                SubCategory = this.SubCategory,
                AccountName = this.AccountName,
            };
        }
        public void SetList(List<Coa> coas)
        {
            _coas = coas;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _coaVMEntryList is set before calling Validate
            if (_coas == null)
            {
                // Log or handle the situation where _coaVMEntryList is not set
                yield break; // Exit the validation early
            }

            // Implement your custom validation logic here
            if (!IsEditing && AlreadyExists(AccountName, ID)) // Check existence only in editing mode
            {
                yield return new ValidationResult("AccountName already exists.", new[] { nameof(AccountName) });
            }
        }

        private bool AlreadyExists(string accountName, int currentItemId)
        {
            bool alreadyExists = false;

            if (accountName != null)
            {
                // Exclude the current item from the search
                var foundItem = _coas.FirstOrDefault(p => p.AccountName == accountName && p.ID != currentItemId);
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }
        public async Task<CoaVM> FromModel(Coa model, Dictionary<string, object> serviceList)
        {
            try
            {
                if (model != null)
                {
                    await Task.Run(() =>
                    {
                        ID = model.ID;
                        Category = model.Category;
                        SubCategory = model.SubCategory;
                        AccountName = model.AccountName;
                    });

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(Coa model, Dictionary<string, object> serviceList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            return this;
        }
        public Coa ToModel(Dictionary<string, object> serviceList)
        {
            return new Coa
            {
                ID = this.ID,
                Category = this.Category,
                SubCategory = this.SubCategory,
                AccountName = this.AccountName,
            };
        }
    }
}
