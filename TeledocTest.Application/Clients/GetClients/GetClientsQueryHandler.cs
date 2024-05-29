﻿
namespace TeledocTest.Application.Clients.GetClients;
internal class GetClientsQueryHandler : IQueryHandler<GetClientsQuery, GetClientsResponse>
{
    private readonly IClientRepository _repository;

    public GetClientsQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetClientsResponse> Handle(GetClientsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.Get(cancellationToken);

        var response = result.Adapt<GetClientsResponse>();

        return response;
    }
}