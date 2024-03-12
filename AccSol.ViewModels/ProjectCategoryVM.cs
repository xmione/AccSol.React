using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class ProjectCategoryVM : ProjectCategory, IValidatableObject, ICloneable<ProjectCategoryVM>, IViewModel<ProjectCategory, ProjectCategoryVM>
    {
        private List<ProjectCategory> _projectCategories = new List<ProjectCategory>(); // Initialize the list
        public bool IsEditing { get; set; } // Boolean property to indicate editing mode
        public ProjectCategoryVM()
        {
        }
        public ProjectCategoryVM(ProjectCategory projectCategory)
        {
            ID = projectCategory.ID;
            Code = projectCategory.Code;
            Name = projectCategory.Name;
        }
        public ProjectCategoryVM(ProjectCategoryVM projectCategoryVM)
        {
            ID = projectCategoryVM.ID;
            Code = projectCategoryVM.Code;
            Name = projectCategoryVM.Name;
        }
        public ProjectCategoryVM Clone()
        {
            return new ProjectCategoryVM
            {
                ID = this.ID,
                Code = this.Code,
                Name = this.Name,
            };
        }

        public void SetList(List<ProjectCategory> projectCategories)
        {
            _projectCategories = projectCategories;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _projectCategoryVMEntryList is set before calling Validate
            if (_projectCategories == null)
            {
                // Log or handle the situation where _projectCategoryVMEntryList is not set
                yield break; // Exit the validation early
            }

            // Implement your custom validation logic here
            if (!IsEditing && AlreadyExists(Code, ID)) // Check existence only in editing mode
            {
                yield return new ValidationResult("Code already exists.", new[] { nameof(Code) });
            }
        }

        private bool AlreadyExists(string? code, int currentItemId)
        {
            bool alreadyExists = false;

            if (code != null)
            {
                // Exclude the current item from the search
                var foundItem = _projectCategories.FirstOrDefault(p => p.Code == code );
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }
        public async Task<ProjectCategoryVM> FromModel(ProjectCategory model, Dictionary<string, object> serviceList)
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
                Console.WriteLine("FromModel(ProjectCategory model, Dictionary<string, object> serviceList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            return this;
        }
        public ProjectCategory ToModel(Dictionary<string, object> serviceList)
        {
            return new ProjectCategory
            {
                ID = this.ID,
                Code = this.Code,
                Name = this.Name,
            };
        }

    }
}
