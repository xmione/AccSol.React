using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class ClientVM : Client, IValidatableObject, ICloneable<ClientVM>, IViewModel<Client, ClientVM>
    {
        private List<Client> _clients = new List<Client>(); // Initialize the list
        public bool IsEditing { get; set; } // Boolean property to indicate editing mode

        public ClientVM(){}
        public ClientVM(Client client)
        {
            ID = client.ID;
            Code = client.Code;
            Name = client.Name;
        }
        public ClientVM(ClientVM clientVM)
        {
            ID = clientVM.ID;
            Code = clientVM.Code;
            Name = clientVM.Name;
        }
        public ClientVM Clone()
        {
            return new ClientVM
            {
                ID = this.ID,
                Code = this.Code,
                Name = this.Name,
            };
        }
        
        public void SetList(List<Client> clients)
        {
            _clients = clients;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _clientVMEntryList is set before calling Validate
            if (_clients == null)
            {
                // Log or handle the situation where _clientVMEntryList is not set
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
                var foundItem = _clients.FirstOrDefault(p => p.Name == name && p.ID != currentItemId);
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }
        public async Task<ClientVM> FromModel(Client model, Dictionary<string, object> serviceList)
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
                Console.WriteLine("FromModel(Client model, Dictionary<string, object> serviceList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            return this;
        }
        public Client ToModel(Dictionary<string, object> serviceList)
        {
            return new Client
            {
                ID = this.ID,
                Code = this.Code,
                Name = this.Name,
            };
        }
    }
}
