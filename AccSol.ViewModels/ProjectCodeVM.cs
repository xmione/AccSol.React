using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class ProjectCodeVM : ProjectCode, IValidatableObject, ICloneable<ProjectCodeVM>, IViewModel<ProjectCode, ProjectCodeVM>
    {
        private List<ProjectCode> _projectCodes = new List<ProjectCode>(); // Initialize the list
        public bool IsEditing { get; set; } // Boolean property to indicate editing mode
        public string ProjectCategoryCode { get; set; } //Important: This will hold the value ISEC and similar ProjectCategory.Code values.
        public string ClientCode { get; set; } //Important: This will hold the value ISEC and similar Client.Code values.
        public ProjectCodeVM()
        {
        }
        public ProjectCodeVM(ProjectCode projectCode)
        {
            ID = projectCode.ID;
            ProjectCategoryID = projectCode.ProjectCategoryID;
            ProjectYear = projectCode.ProjectYear;
            ClientID = projectCode.ClientID;
            ProjectNumber = projectCode.ProjectNumber;
            Code = projectCode.Code;
            Description = projectCode.Description;
        }
        public ProjectCodeVM(ProjectCodeVM projectCodeVM)
        {
            ID = projectCodeVM.ID;
            ProjectCategoryID = projectCodeVM.ProjectCategoryID;
            ProjectYear = projectCodeVM.ProjectYear;
            ClientID = projectCodeVM.ClientID;
            ProjectNumber = projectCodeVM.ProjectNumber;
            Code = projectCodeVM.Code;
            Description = projectCodeVM.Description;
        }
        public ProjectCodeVM Clone()
        {
            var projectCodeVM = new ProjectCodeVM
            {
                ID = this.ID,
                ProjectCategoryID = this.ProjectCategoryID,
                ProjectYear = this.ProjectYear,
                ClientID = this.ClientID,
                ProjectNumber = this.ProjectNumber,
                Code = this.Code,
                Description = this.Description,
            };

            return projectCodeVM;
        }

        public void SetList(List<ProjectCode> projectCodes)
        {
            _projectCodes = projectCodes;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _projectCodeVMEntryList is set before calling Validate
            if (_projectCodes == null)
            {
                // Log or handle the situation where _projectCodeVMEntryList is not set
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
                var foundItem = _projectCodes.FirstOrDefault(p => p.Code == code );
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }
        public async Task<ProjectCodeVM> FromModel(ProjectCode model, Dictionary<string, object> collectionList)
        {
            try 
            {
                ID = model.ID;
                ProjectCategoryID = model.ProjectCategoryID;
                ProjectYear = model.ProjectYear;
                ClientID = model.ClientID;
                ProjectNumber = model.ProjectNumber;
                Code = await GetCode(collectionList);
                Description = model.Description;
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(ProjectCode model, Dictionary<string, object> collectionList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
            
            return this;
        }
        public ProjectCode ToModel(Dictionary<string, object> collectionList)
        {
            var projectCode = new ProjectCode
            {
                ID = this.ID,
                ProjectCategoryID = this.ProjectCategoryID,
                ProjectYear = this.ProjectYear,
                ClientID = this.ClientID,
                ProjectNumber = this.ProjectNumber,
                Code = GetCode(collectionList).Result,
                Description = this.Description
            };

            return projectCode;
        }

        private async Task<string> GetCode(Dictionary<string, object> collectionList) 
        {
            string code = string.Empty;
            object? projectCategories;
            object? clients;

            try 
            {
                collectionList.TryGetValue("ProjectCategory", out projectCategories);
                collectionList.TryGetValue("Client", out clients);

                var pcs = (IEnumerable<ProjectCategory>?)projectCategories;
                var cs = (IEnumerable<Client>?)clients;

                if (pcs != null) 
                {
                    var projectCategory = pcs.FirstOrDefault(p => p.ID == ProjectCategoryID);
                    if (projectCategory != null)
                    {
                        ProjectCategoryCode = projectCategory.Code ?? string.Empty;
                    }
                }

                if (cs != null) 
                {
                    var client = cs.FirstOrDefault(p => p.ID == ClientID);
                    if (client != null)
                    {
                        ClientCode = client.Code ?? string.Empty;
                    }
                }

                string year = string.Empty;
                if (ProjectYear != null) 
                {
                    ProjectYear.ToString();
                }  

                string[] codeArray = { ProjectCategoryCode ?? string.Empty, year, ClientCode ?? string.Empty, ProjectNumber ?? string.Empty };
                code = string.Join("-", codeArray);

                if (ProjectCategoryCode is null || ProjectYear is null || ClientCode is null || ProjectNumber is null)
                {
                    code = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetCode(Dictionary<string, object> collectionList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            await Task.CompletedTask;
            return code;
        }
    }
}
