using AccSol.Models;
using System.ComponentModel.DataAnnotations;

namespace AccSol.ViewModels
{
    public class JournalVM : Journal, IValidatableObject, ICloneable<JournalVM>, IViewModel<Journal, JournalVM>
    {
        public string? AccountName { get; set; }
        private List<JournalVM> _journalVMEntryList = new List<JournalVM>(); // Initialize the list
        private List<Coa> _coas = new List<Coa>(); // Initialize the list
        public bool IsEditing { get; set; } // Boolean property to indicate editing mode
        public JournalVM() { }
        public JournalVM(Journal journal)
        {
            ID = journal.ID;
            PettyCashID = journal.PettyCashID;
            Debit = journal.Debit;
            Credit = journal.Credit;
        }
        public JournalVM(JournalVM journalVM)
        {
            ID = journalVM.ID;
            PettyCashID = journalVM.PettyCashID;
            Debit = journalVM.Debit;
            Credit = journalVM.Credit;
            CoaID = journalVM.CoaID;
            AccountName = journalVM.AccountName;
        }

        public JournalVM(Journal journal, List<Coa> coas)
        {
            _coas = coas;

            ID = journal.ID;
            PettyCashID = journal.PettyCashID;
            Debit = journal.Debit;
            Credit = journal.Credit;

            int coaId = journal.CoaID ?? _coas[0].ID;
            CoaID = coaId;

            AccountName = GetAccountName(coaId);
        }
        public JournalVM(JournalVM journalVM, List<Coa> coas)
        {
            _coas = coas;

            ID = journalVM.ID;
            PettyCashID = journalVM.PettyCashID;
            Debit = journalVM.Debit;
            Credit = journalVM.Credit;

            int coaId = journalVM.CoaID ?? _coas[0].ID;
            CoaID = coaId;

            AccountName = journalVM.CoaID != null? journalVM.AccountName : GetAccountName(coaId);
            
        }
        public JournalVM Clone()
        {
            return new JournalVM
            {
                ID = this.ID,
                PettyCashID = this.PettyCashID,
                Debit = this.Debit,
                Credit = this.Credit,
                CoaID = this.CoaID,
                AccountName = this.AccountName,
        };
        }
        public void SetJournalEntryVMList(List<JournalVM> journalVMEntryList)
        {
            _journalVMEntryList = journalVMEntryList;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ensure _journalVMEntryList is set before calling Validate
            if (_journalVMEntryList == null)
            {
                // Log or handle the situation where _journalVMEntryList is not set
                yield break; // Exit the validation early
            }

            // Implement your custom validation logic here
            //if (!IsEditing && AlreadyExists(AccountName, ID)) // Check existence only in editing mode
            //{
            //    yield return new ValidationResult("AccountName already exists.", new[] { nameof(AccountName) });
            //}
        }

        private bool AlreadyExists(string accountName, int currentItemId)
        {
            bool alreadyExists = false;

            if (accountName != null)
            {
                // Exclude the current item from the search
                var foundItem = _journalVMEntryList.FirstOrDefault(p => p.AccountName == accountName && p.ID != currentItemId);
                alreadyExists = foundItem != null;
            }

            return alreadyExists;
        }

        private string GetAccountName(int coaId)
        {
            string name = string.Empty;

            var foundName = _coas?.FirstOrDefault(c => c.ID == coaId)?.AccountName;
            name = foundName ?? string.Empty;
            
            return name;
        }
        public async Task<JournalVM> FromModel(Journal model, Dictionary<string, object> collectionList)
        {
            try 
            {
                ID = model.ID;
                PettyCashID = model.PettyCashID;
                Debit = model.Debit;
                Credit = model.Credit;
                CoaID = model.CoaID;

                if (collectionList != null)
                {
                    await GetCode(collectionList);
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("FromModel(Journal model, Dictionary<string, object> collectionList): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            return this;
        }
        public Journal ToModel(Dictionary<string, object> collectionList)
        {
            return new Journal
            {
                ID = this.ID,
                PettyCashID = this.PettyCashID,
                Debit = this.Debit,
                Credit = this.Credit,
                CoaID = this.CoaID,
                
            };
        }

        private async Task GetCode(Dictionary<string, object> collectionList)
        {
            object? coas;

            try 
            {
                collectionList.TryGetValue("Coa", out coas);

                var cs = (IEnumerable<Coa>?)coas;

                var coa = cs.FirstOrDefault(p => p.ID == CoaID);
                if (coa != null)
                {
                    AccountName = coa.AccountName;
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
