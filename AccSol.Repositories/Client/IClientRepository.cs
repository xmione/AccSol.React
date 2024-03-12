using AccSol.Models;

namespace AccSol.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll(bool trackChanges);
        Client? Get(int? id, bool trackChanges);
        void DeleteClient(Client client);
        Client? SaveClient(Client client);
    }
}
