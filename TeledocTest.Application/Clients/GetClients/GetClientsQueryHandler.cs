namespace TeledocTest.Application.Clients;
public class GetClientsQueryHandler : IQueryHandler<GetClientsQuery, GetClientsResponse>
{
    private readonly IClientRepository _repository;

    public GetClientsQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetClientsResponse> Handle(GetClientsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.Get(cancellationToken);

        var response = new GetClientsResponse(result.Adapt<IEnumerable<ClientWithRelationsResponse>>());

        return response;
    }
}
