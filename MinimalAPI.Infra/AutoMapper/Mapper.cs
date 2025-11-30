using AutoMapper;
using MinimalAPI.Domain.Request;
using MinimalAPI.Domain.Response;
using MinimalAPI.Infra.Entities;

namespace MinimalAPI.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            #region .: Client :.
            CreateMap<Client, ClientResponse>();
            CreateMap<Client, ClientRequest>().ReverseMap();
            #endregion
        }

    }

}
