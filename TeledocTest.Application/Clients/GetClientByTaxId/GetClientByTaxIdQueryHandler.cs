namespace TeledocTest.Application.Clients;
public class GetClientByTaxIdQueryHandler : IQueryHandler<GetClientByTaxIdQuery, GetClientByTaxIdResponse>
{
    private readonly IClientRepository _repository;

    public GetClientByTaxIdQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetClientByTaxIdResponse> Handle(GetClientByTaxIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByTaxId(request.TaxId, cancellationToken);

        var response = result.Adapt<GetClientByTaxIdResponse>();

        return response;
    }
}
