using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class PayeeVM : Payee, IValidatableObject, ICloneable<PayeeVM>, IViewModel<Payee, PayeeVM>
    {
        private List<Payee> _payees = new List<Payee>(); // Initialize the list
        public bool IsEditing { get; set; } = false;// Boolean property to indicate editing mode
        public string PayeeName { get; set; } = null!; 
        public string PayeeCategoryName { get; set; } = null!; 

        public PayeeVM()
        {
        }
        public PayeeVM(Payee payee)
        {
            ID = payee.ID;
            FirstName = payee.FirstName;
            MiddleName = payee.MiddleName;
            LastName = payee.LastName;
            PayeeName = string.Join(" ", [payee?.FirstName?.Trim(), payee?.MiddleName?.Trim(), payee?.LastName?.Trim()]); 
            EmployeeID = payee.EmployeeID;
            PayeeCategoryID = payee.PayeeCategoryID;
        }
        public PayeeVM(PayeeVM payeeVM)
        {
            ID = payeeVM.ID;
            FirstName = payeeVM.FirstName;
            MiddleName = payeeVM.MiddleName;
            LastName = payeeVM.LastName;
            PayeeName = string.Join(" ", [payeeVM?.FirstName?.Trim(), payeeVM?.MiddleName?.Trim(), payeeVM?.LastName?.Trim()]);
            EmployeeID = payeeVM.EmployeeID;
            PayeeCategoryID = payeeVM.PayeeCategoryID;
        }
        public PayeeVM Clone()
        {
            return new PayeeVM
            {
                ID = this.ID,
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                PayeeName = string.Join(" ", [this?.FirstName?.Trim(), this?.MiddleName?.Trim(), this?.LastName?.Trim()]),
                EmployeeID = this.EmployeeID,
                PayeeCategoryID = this.PayeeCategoryID,
            };
        }

        public void SetList(List<Payee> payees)
        {
            _payees = payees;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            // Ensure _payeeVMEntryList is set before calling Validate
            if (_payees == null)
            {
                // Log or handle the situation where _payeeVMEntryList is not set
                yield break; // Exit the validation early
            }

            // Implement your custom validation logic here
            if (!IsEditing && AlreadyExists(FirstName, MiddleName, LastName, EmployeeID)) // Check existence only in editing mode
            {
                yield return new ValidationResult("Name already exists.", new[] { nameof(PayeeName) });
            }
        }

        private bool AlreadyExists(string? firstName = "", string? middleName = "", string? lastName = "", int? employeeId =-1, int? payeeCategoryId = -1)
        {
            bool alreadyExists = false;

            // Exclude the current item from the search
            var foundItem = _payees.FirstOrDefault(p => p.FirstName == firstName && p.MiddleName == middleName
            && p.LastName == lastName && p.EmployeeID == employeeId );

            alreadyExists = foundItem != null;

            return alreadyExists;
        }
        public async Task<PayeeVM> FromModel(Payee model, Dictionary<string, object> collectionList)
        {
            try
            {
                if (model != null)
                {
                    ID = model.ID;
                    MiddleName = model.MiddleName;
                    LastName = model.LastName;
                    FirstName = model.FirstName;
                    EmployeeID = model.EmployeeID;
                    PayeeCategoryID = model.PayeeCategoryID;

                    if (collectionList != null)
                    {
                        await GetCode(collectionList);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(Payee model, Dictionary<string, object> collectionList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
            
            return this;
        }
        public Payee ToModel(Dictionary<string, object> collectionList)
        {
            Payee payee = default!;
            payee = new Payee
            {
                ID = this.ID,
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                EmployeeID = this.EmployeeID,
                PayeeCategoryID = this.PayeeCategoryID,
            };

            return payee;
        }
        private async Task GetCode(Dictionary<string, object> collectionList)
        {
            try 
            {
                int employeeId = EmployeeID.GetValueOrDefault();

                if (employeeId > 0)
                {
                    object? employees;
                    collectionList.TryGetValue("Employee", out employees);

                    var ds = (IEnumerable<Employee>?)employees;

                    Console.WriteLine("Employee ID: {0}", employeeId);

                    if (ds != null) 
                    {
                        var employee = ds.FirstOrDefault(p => p.ID == employeeId);
                        if (employee != null)
                        {

                            var name = employee.FirstName + " " + employee.MiddleName + " " + employee.LastName;
                            Console.WriteLine("Employee Name: {0}", name);
                            PayeeName = name ?? string.Empty;
                        }
                    }
                }

                int payeeCategoryId = PayeeCategoryID.GetValueOrDefault();

                if (payeeCategoryId > 0)
                {
                    object? payeeCategories;
                    collectionList.TryGetValue("PayeeCategory", out payeeCategories);

                    var pcs = (IEnumerable<PayeeCategory>?)payeeCategories;

                    Console.WriteLine("Payee Category ID: {0}", payeeCategoryId);

                    if (pcs != null)
                    {
                        var payeeCategory = pcs.FirstOrDefault(p => p.ID == payeeCategoryId);
                        if (payeeCategory != null)
                        {

                            var payeeCategoryName = payeeCategory.Name;
                            Console.WriteLine("Payee Category Name: {0}", payeeCategoryName);
                            PayeeCategoryName = payeeCategoryName ?? string.Empty;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("GetCode(Dictionary<string, object> collectionList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            await Task.CompletedTask;
        }
    }
}
