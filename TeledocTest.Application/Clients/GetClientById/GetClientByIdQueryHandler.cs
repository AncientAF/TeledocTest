namespace TeledocTest.Application.Clients.GetClientById;
public class GetClientByIdQueryHandler : IQueryHandler<GetClientByIdQuery, GetClientByIdResponse>
{
    private readonly IClientRepository _repository;

    public GetClientByIdQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetClientByIdResponse> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id, cancellationToken);

        var response = result.Adapt<GetClientByIdResponse>();

        return response;
    }
}
