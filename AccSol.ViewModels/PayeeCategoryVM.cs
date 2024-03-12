using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class PayeeCategoryVM : PayeeCategory, IValidatableObject, ICloneable<PayeeCategoryVM>, IViewModel<PayeeCategory, PayeeCategoryVM>
    {
        private List<PayeeCategory> _payeeCategories = new List<PayeeCategory>(); // Initialize the list
        public bool IsEditing { get; set; } // Boolean property to indicate editing mode

        public PayeeCategoryVM(){}
        public PayeeCategoryVM(PayeeCategory payeeCategory)
        {
            ID = payeeCategory.ID;
            Code = payeeCategory.Code;
            Name = payeeCategory.Name;
        }
        public PayeeCategoryVM(PayeeCategoryVM payeeCategoryVM)
        {
            ID = payeeCategoryVM.ID;
            Code = payeeCategoryVM.Code;
            Name = payeeCategoryVM.Name;
        }
        public PayeeCategoryVM Clone()
        {
            return new PayeeCategoryVM
            {
                ID = this.ID,
                Code = this.Code,
                Name = this.Name,
            };
        }
        
        public void SetList(List<PayeeCategory> payeeCategories)
        {
            _payeeCategories = payeeCategories;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _payeeCategoryVMEntryList is set before calling Validate
            if (_payeeCategories == null)
            {
                // Log or handle the situation where _payeeCategoryVMEntryList is not set
                yield break; // Exit the validation early
            }

            // Implement your custom validation logic here
            //if (!IsEditing && AlreadyExists(Name, ID)) // Check existence only in editing mode
            //{
            //    yield return new ValidationResult("Name already exists.", new[] { nameof(Name) });
            //}
        }

        private bool AlreadyExists(string name, int currentItemId)
        {
            bool alreadyExists = false;

            if (name != null)
            {
                // Exclude the current item from the search
                var foundItem = _payeeCategories.FirstOrDefault(p => p.Name == name && p.ID != currentItemId);
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }
        public async Task<PayeeCategoryVM> FromModel(PayeeCategory model, Dictionary<string, object> serviceList)
        {
            try
            {
                if (model != null)
                {
                    await Task.Run(() => 
                    {
                        ID = model.ID;
                        Code = model.Code;
                        Name = model.Name;
                    });
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(PayeeCategory model, Dictionary<string, object> serviceList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            return this;
        }
        public PayeeCategory ToModel(Dictionary<string, object> serviceList)
        {
            return new PayeeCategory
            {
                ID = this.ID,
                Code = this.Code,
                Name = this.Name,
            };
        }
    }
}
