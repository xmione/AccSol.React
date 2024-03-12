using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class PettyCashVM : PettyCash, IValidatableObject, ICloneable<PettyCashVM>, IViewModel<PettyCash, PettyCashVM>
    {
        private string? _projectCode;
        public string? ProjectCode 
        {
            get { return _projectCode; }
            set { _projectCode = value; }
        }

        private string? _departmentCode;
        public string? DepartmentCode
        {
            get { return _departmentCode; }
            set { _departmentCode = value; }
        }

        private string? _departmentName;
        public string? DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        private string? _clientCode;
        public string? ClientCode
        {
            get { return _clientCode; }
            set { _clientCode = value; }
        }

        private string? _clientName;
        public string? ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }
        // Initialize the lists
        private List<PettyCash> _pettyCashList = new List<PettyCash>(); 
        private List<Client> _clients = new List<Client>(); 
        private List<ProjectCode> _projectCategories = new List<ProjectCode>(); 
        private List<Department> _departments = new List<Department>(); 

        public bool IsEditing { get; set; } // Boolean property to indicate editing mode

        public PettyCashVM() { }
        public PettyCashVM(PettyCash pettyCash)
        {
            ID = pettyCash.ID;
            PCFNo = pettyCash.PCFNo;
            Date = pettyCash.Date;
            PayeeID = pettyCash.PayeeID;
            Particulars = pettyCash.Particulars;
            Amount = pettyCash.Amount;
            ProjectCodeID = pettyCash.ProjectCodeID;
        }
        public PettyCashVM(PettyCashVM pettyCashVM)
        {
            ID = pettyCashVM.ID;
            PCFNo = pettyCashVM.PCFNo;
            Date = pettyCashVM.Date;
            PayeeID = pettyCashVM.PayeeID;
            Particulars = pettyCashVM.Particulars;
            Amount = pettyCashVM.Amount;
            
            ProjectCodeID = pettyCashVM.ProjectCodeID;
            ProjectCode = pettyCashVM.ProjectCode;

            DepartmentID = pettyCashVM.DepartmentID;
            DepartmentCode = pettyCashVM.DepartmentCode;
            DepartmentName = pettyCashVM.DepartmentName;

            ClientID = pettyCashVM.ClientID;
            ClientCode = pettyCashVM.ClientCode;
            ClientName = pettyCashVM.ClientName;
        }
        public PettyCashVM(PettyCash pettyCash, List<Client> clientList, List<ProjectCode> projectCodeList, List<Department> departmentList)
        {
            _clients = clientList;
            _projectCategories = projectCodeList;
            _departments = departmentList;

            ID = pettyCash.ID;
            PCFNo = pettyCash.PCFNo;
            Date = pettyCash.Date;
            PayeeID = pettyCash.PayeeID;
            Particulars = pettyCash.Particulars;
            Amount = pettyCash.Amount;
            
            int projectCodeId = pettyCash.ProjectCodeID ?? _projectCategories[0].ID;
            int departmentId = pettyCash.DepartmentID?? _departments[0].ID;
            int clientId = pettyCash.ClientID?? _clients[0].ID;
            
            ProjectCodeID = projectCodeId;
            DepartmentID = departmentId;
            ClientID = clientId;

            ProjectCode = GetProjectCode(projectCodeId);
            DepartmentCode = GetDepartmentCode(departmentId);
            ClientName = GetClientName(clientId);
        }
        public PettyCashVM(PettyCashVM pettyCashVM, List<Client> clientList, List<ProjectCode> projectCodeList, List<Department> departmentList)
        {
            
            _clients = clientList;
            _projectCategories = projectCodeList;
            _departments = departmentList;

            ID = pettyCashVM.ID;
            PCFNo = pettyCashVM.PCFNo;
            Date = pettyCashVM.Date;
            PayeeID = pettyCashVM.PayeeID;
            Particulars = pettyCashVM.Particulars;
            Amount = pettyCashVM.Amount;

            int projectCodeId = pettyCashVM.ProjectCodeID ?? _projectCategories[0].ID;
            int departmentId = pettyCashVM.DepartmentID?? _departments[0].ID;
            int clientId = pettyCashVM.ClientID ?? _clients[0].ID;

            ProjectCodeID = projectCodeId;
            DepartmentID = departmentId;
            ClientID = clientId;

            ProjectCode = pettyCashVM.ProjectCodeID != null? pettyCashVM.ProjectCode : GetProjectCode(projectCodeId);
            DepartmentCode = pettyCashVM.DepartmentID != null? pettyCashVM.DepartmentCode: GetDepartmentCode(departmentId);
            ClientName = pettyCashVM.ClientID!= null? pettyCashVM.ClientName: GetClientName(clientId);
        }

        public PettyCashVM Clone()
        {
            return new PettyCashVM
            {
                ID = this.ID,
                PCFNo = this.PCFNo,
                Date = this.Date,
                PayeeID = this.PayeeID,
                Particulars = this.Particulars,
                Amount = this.Amount,
                ProjectCodeID = this.ProjectCodeID,
                ProjectCode = this.ProjectCode,
                ClientID = this.ClientID,
            };
        }

        public void SetList(List<PettyCash> pettyCashList)
        {
            _pettyCashList = pettyCashList;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _pettyCashList is set before calling Validate
            if (_pettyCashList == null)
            {
                // Log or handle the situation where _pettyCashList is not set
                yield break; // Exit the validation early
            }

            string pcFNo = PCFNo ?? string.Empty;
            // Implement your custom validation logic here
            if (!IsEditing && AlreadyExists(pcFNo, ID)) // Check existence only in editing mode
            {
                yield return new ValidationResult("PCFNo already exists.", new[] { nameof(PCFNo) });
            }
        }

        private bool AlreadyExists(string pcfNo, int currentItemId)
        {
            bool alreadyExists = false;

            if (pcfNo != null)
            {
                // Exclude the current item from the search
                var foundItem = _pettyCashList.FirstOrDefault(p => p.PCFNo == pcfNo && p.ID != currentItemId);
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }

        private string GetClientName(int id)
        {
            string name = string.Empty;

            name = _clients?.FirstOrDefault(c => c.ID == id)?.Name ?? string.Empty;

            return name;
        }
        
        private string GetDepartmentCode(int id)
        {
            string code = string.Empty;

            code = _departments?.FirstOrDefault(c => c.ID == id)?.Code ?? string.Empty;

            return code;
        }

        private string GetProjectCode(int id)
        {
            string name = string.Empty;

            name = _projectCategories?.FirstOrDefault(c => c.ID == id)?.Description ?? string.Empty;

            return name;
        }
        public async Task<PettyCashVM> FromModel(PettyCash model, Dictionary<string, object> collectionList)
        {
            try
            {
                ID = model.ID;
                PCFNo = model.PCFNo;
                Date = model.Date;
                PayeeID = model.PayeeID;
                Particulars = model.Particulars;
                Amount = model.Amount;

                // for the searchbox IDs
                ProjectCodeID = model.ProjectCodeID;
                DepartmentID = model.DepartmentID;
                ClientID = model.ClientID;
                
                if (collectionList != null)
                {
                    await GetCode(collectionList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(PettyCash model, Dictionary<string, object> serviceList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
            
            return this;
        }
        public PettyCash ToModel(Dictionary<string, object> collectionList)
        {
            return new PettyCash
            {
                ID = this.ID,
                PCFNo = this.PCFNo,
                Date = this.Date,
                PayeeID = this.PayeeID,
                Particulars = this.Particulars,
                Amount = this.Amount,
                ProjectCodeID = this.ProjectCodeID,
                DepartmentID = this.DepartmentID,
                ClientID = this.ClientID,
            };
        }

        private async Task GetCode(Dictionary<string, object> collectionList)
        {
            object? projectCodes;
            object? departments;
            object? clients;

            try 
            {
                collectionList.TryGetValue("ProjectCode", out projectCodes);
                collectionList.TryGetValue("Department", out departments);
                collectionList.TryGetValue("Client", out clients);

                var pcs = (IEnumerable<ProjectCode>?)projectCodes;
                var ds = (IEnumerable<Department>?)departments;
                var cs = (IEnumerable<Client>?)clients;

                var projectCode = pcs?.FirstOrDefault(p => p.ID == ProjectCodeID);
                if (projectCode != null)
                {
                    _projectCode = projectCode.Code;
                }

                var department = ds?.FirstOrDefault(p => p.ID == DepartmentID);
                if (department != null)
                {
                    _departmentCode = department.Code;
                    _departmentName = department.Name;
                }

                var client = cs?.FirstOrDefault(p => p.ID == ClientID);
                if (client != null)
                {
                    _clientCode = client.Code;
                    _clientName = client.Name;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetCode(Dictionary<string, object> serviceList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            await Task.CompletedTask;
        }
    }
}
