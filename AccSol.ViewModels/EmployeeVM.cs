using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class EmployeeVM : Employee, IValidatableObject, ICloneable<EmployeeVM>, IViewModel<Employee, EmployeeVM>
    {
        public string? Name 
        {
            get { return FirstName?.Trim() + " " + MiddleName?.Trim() + " " + LastName?.Trim(); }
        }
        private List<Employee> _employees = new List<Employee>(); // Initialize the list
        public bool IsEditing { get; set; } = false;// Boolean property to indicate editing mode
        public string DepartmentName { get; set; } = null!; //Important: This will hold the value ACCT001 and similar Department.Code values.

        public EmployeeVM()
        {
        }
        public EmployeeVM(Employee employee)
        {
            ID = employee.ID;
            EmployeeNumber = employee.EmployeeNumber;
            FirstName = employee.FirstName;
            MiddleName = employee.MiddleName;
            LastName = employee.LastName;
            DepartmentID = employee.DepartmentID;
        }
        public EmployeeVM(EmployeeVM employeeVM)
        {
            ID = employeeVM.ID;
            EmployeeNumber = employeeVM.EmployeeNumber;
            FirstName = employeeVM.FirstName;
            MiddleName = employeeVM.MiddleName;
            LastName = employeeVM.LastName;
            DepartmentID = employeeVM.DepartmentID;
        }
        public EmployeeVM Clone()
        {
            return new EmployeeVM
            {
                ID = this.ID,
                EmployeeNumber = this.EmployeeNumber,
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                DepartmentID = this.DepartmentID,
            };
        }

        public void SetList(List<Employee> employees)
        {
            _employees = employees;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            // Ensure _employeeVMEntryList is set before calling Validate
            if (_employees == null)
            {
                // Log or handle the situation where _employeeVMEntryList is not set
                yield break; // Exit the validation early
            }

            // Implement your custom validation logic here
            if (!IsEditing && AlreadyExists(FirstName, MiddleName, LastName, DepartmentID)) // Check existence only in editing mode
            {
                yield return new ValidationResult("Name already exists.", new[] { nameof(Name) });
            }
        }

        private bool AlreadyExists(string? firstName = "", string? middleName = "", string? lastName = "", int? departmentId =-1, int? payeeCategoryId = -1)
        {
            bool alreadyExists = false;

            // Exclude the current item from the search
            var foundItem = _employees.FirstOrDefault(p => p.FirstName == firstName && p.MiddleName == middleName
            && p.LastName == lastName && p.DepartmentID == departmentId );

            alreadyExists = foundItem != null;

            return alreadyExists;
        }
        public async Task<EmployeeVM> FromModel(Employee model, Dictionary<string, object> collectionList)
        {
            try
            {
                if (model != null)
                {
                    ID = model.ID;
                    EmployeeNumber = model.EmployeeNumber;
                    MiddleName = model.MiddleName;
                    LastName = model.LastName;
                    FirstName = model.FirstName;
                    DepartmentID = model.DepartmentID;

                    if (collectionList != null)
                    {
                        await GetCode(collectionList);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(Employee model, Dictionary<string, object> collectionList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
            
            return this;
        }
        public Employee ToModel(Dictionary<string, object> collectionList)
        {
            Employee employee = default!;
            employee = new Employee
            {
                ID = this.ID,
                EmployeeNumber = this.EmployeeNumber,
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                DepartmentID = this.DepartmentID,
                
            };

            return employee;
        }
        private async Task GetCode(Dictionary<string, object> collectionList)
        {
            try 
            {
                int departmentId = DepartmentID.GetValueOrDefault();

                if (departmentId > 0)
                {
                    object? departments;
                    collectionList.TryGetValue("Department", out departments);

                    var ds = (IEnumerable<Department>?)departments;

                    Console.WriteLine("Department ID: {0}", departmentId);

                    if (ds != null) 
                    {
                        var department = ds.FirstOrDefault(p => p.ID == departmentId);
                        if (department != null)
                        {
                            Console.WriteLine("Department Code: {0}", department.Name);
                            DepartmentName = department.Name ?? string.Empty;
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
