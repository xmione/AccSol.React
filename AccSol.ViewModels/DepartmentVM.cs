using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class DepartmentVM : Department, IValidatableObject, ICloneable<DepartmentVM>, IViewModel<Department, DepartmentVM>
    {
        private List<Department> _departments = new List<Department>(); // Initialize the list
        public bool IsEditing { get; set; } // Boolean property to indicate editing mode
        public DepartmentVM()
        {
        }
        public DepartmentVM(Department department)
        {
            ID = department.ID;
            Code = department.Code;
            Name = department.Name;
        }
        public DepartmentVM(DepartmentVM departmentVM)
        {
            ID = departmentVM.ID;
            Code = departmentVM.Code;
            Name = departmentVM.Name;
        }
        public DepartmentVM Clone()
        {
            return new DepartmentVM
            {
                ID = this.ID,
                Code = this.Code,
                Name = this.Name,
            };
        }
        public void SetList(List<Department> departments)
        {
            _departments = departments;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _departmentVMEntryList is set before calling Validate
            if (_departments == null)
            {
                // Log or handle the situation where _departmentVMEntryList is not set
                yield break; // Exit the validation early
            }

            // Implement your custom validation logic here
            if (!IsEditing && AlreadyExists(Code, ID)) // Check existence only in editing mode
            {
                yield return new ValidationResult("Code already exists.", new[] { nameof(Code) });
            }
            
        }

        private bool AlreadyExists(string code, int currentItemId)
        {
            bool alreadyExists = false;

            if (code != null)
            {
                // Exclude the current item from the search
                var foundItem = _departments.FirstOrDefault(p => p.Code == code && p.ID != currentItemId);
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }
    public async Task<DepartmentVM> FromModel(Department model, Dictionary<string, object> serviceList)
    {
            try
            {
                if (model != null)
                {
                    ID = model.ID;
                    Code = model.Code;
                    Name = model.Name;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(FromModel(Department model, Dictionary<string, object> serviceList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            return this;
        }
    public Department ToModel(Dictionary<string, object> serviceList)
        {
        return new Department
        {
            ID = this.ID,
            Code = this.Code,
            Name = this.Name,
        };
    }
}
}
