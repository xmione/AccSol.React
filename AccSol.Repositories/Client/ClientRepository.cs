using AccSol.EF.Data;
using AccSol.Models;

namespace AccSol.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Client> GetAll(bool trackChanges) =>
        FindAll(trackChanges)
        .ToList();
        public Client? Get(int? id, bool trackChanges) =>
        FindByCondition(c => c.ID == id, trackChanges)
        .FirstOrDefault();
        public void DeleteClient(Client client) => Delete(client);
        public Client? SaveClient(Client client)
        {
            // checked if it is a new entry
            if (client.ID == 0)
            {
                //if it is, check the name if it exists
                var foundName = GetAll(trackChanges: false).Where(n => n.Name.Contains(client.Name.Trim())).FirstOrDefault();
                if (foundName != null)
                {
                    client = Update(client);
                }
                else 
                {
                    client = Create(client);
                }
            }
            else 
            {
                //if it is not a new entry update
                client = Update(client);
            }

            return client;
        }
    }
}