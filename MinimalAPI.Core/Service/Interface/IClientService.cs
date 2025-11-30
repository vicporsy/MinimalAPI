using MinimalAPI.Domain;
using MinimalAPI.Domain.Request;
using MinimalAPI.Domain.Response;
using MinimalAPI.Infra.Entities;

namespace MinimalAPI.Service.Interface
{
    public interface IClientService
    {
        Task<Client?> GetById(int id);
        Task PostClient(ClientRequest client);
    }
}
