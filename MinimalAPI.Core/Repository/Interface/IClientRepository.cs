using MinimalAPI.Infra.Entities;

namespace MinimalAPI.Core.Repository.Interface
{
    public interface IClientRepository
    {
        Task<Client?> GetById(int id);
        Task PostClient(Client client);
    }
}
