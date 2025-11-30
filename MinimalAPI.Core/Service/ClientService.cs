using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using MinimalAPI.Core.Repository.Interface;
using MinimalAPI.Domain.Request;
using MinimalAPI.Service.Interface;
using MinimalAPI.Infra.Contexts;
using MinimalAPI.Infra.Entities;

namespace MinimalAPI.Core.Service
{
    public class ClientService : IClientService
    {
        private readonly AppDbContext _context;
        private readonly IClientRepository _repository;
        private readonly IMemoryCache _cache;
        private readonly IMapper _mapper;
        public ClientService(AppDbContext context, IClientRepository repository, IMemoryCache cache, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _cache = cache;
            _mapper = mapper;
        }

        public async Task<Client?> GetById(int id)
        {
            var client = _cache.Get<Client>($"victor:client:{id}");

            if(client is null)
            {
                client = await _repository.GetById(id);

                if (client is not null)
                    _cache.Set($"victor:client:{id}", client);
            }

            return client;
        }

        public async Task PostClient(ClientRequest client)
        {
            var clientEntity = _mapper.Map<Client>(client);

            await _repository.PostClient(clientEntity);

            await _context.SaveChangesAsync();
        }
    }
}