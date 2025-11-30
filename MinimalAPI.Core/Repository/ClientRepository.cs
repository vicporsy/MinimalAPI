using Microsoft.EntityFrameworkCore;
using MinimalAPI.Core.Repository.Interface;
using MinimalAPI.Infra.Contexts;
using MinimalAPI.Infra.Entities;

namespace MinimalAPI.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;
        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Client?> GetById(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task PostClient(Client client)
        {
            if (client.Id is null)
                _context.Clientes.Add(client);

            else
                _context.Clientes.Update(client);
        }
    }
}
