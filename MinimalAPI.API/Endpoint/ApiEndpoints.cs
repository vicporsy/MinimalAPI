using AutoMapper;
using MinimalAPI.Domain.Request;
using MinimalAPI.Domain.Response;
using MinimalAPI.Service.Interface;
using System.Text.Json;

namespace MinimalAPI.Endpoint
{
    public static class ApiEndpoints
    {
        public static void MapApiEndpoints(this IEndpointRouteBuilder router)
        {
            var clientEndpoints = router.MapGroup("client/").WithTags("Cliente");

            clientEndpoints.MapGet("GetById/{id}", async (int id, IClientService _service, IMapper mapper) =>
            {
                var entity = await _service.GetById(id);

                var response = mapper.Map<ClientResponse>(entity);

                return Results.Ok(response);
            });

            clientEndpoints.MapPost("PostClient", async (ClientRequest request, IClientService _service) =>
            {
                await _service.PostClient(request);
            });

        }
    }
}
