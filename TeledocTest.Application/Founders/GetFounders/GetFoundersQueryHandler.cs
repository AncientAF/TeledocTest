
namespace TeledocTest.Application.Founders;
public class GetFoundersQueryHandler : IQueryHandler<GetFoundersQuery, GetFoundersResponse>
{
    private readonly IFounderRepository _repository;

    public GetFoundersQueryHandler(IFounderRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetFoundersResponse> Handle(GetFoundersQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.Get(cancellationToken);

        var response = new GetFoundersResponse(result.Adapt<IEnumerable<FounderWithRelationsResponse>>());

        return response;
    }
}
