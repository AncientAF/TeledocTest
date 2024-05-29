namespace TeledocTest.Application.Founders;
public class GetFounderByTaxIdQueryHandler : IQueryHandler<GetFounderByTaxIdQuery, GetFounderByTaxIdResponse>
{
    private readonly IFounderRepository _repository;

    public GetFounderByTaxIdQueryHandler(IFounderRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetFounderByTaxIdResponse> Handle(GetFounderByTaxIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByTaxId(request.TaxId, cancellationToken);

        var response = result.Adapt<GetFounderByTaxIdResponse>();

        return response;
    }
}
