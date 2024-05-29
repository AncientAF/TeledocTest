
namespace TeledocTest.Application.Founders.GetFounderById;
public class GetFounderByIdQueryHandler : IQueryHandler<GetFounderByIdQuery, GetFounderByIdResponse>
{
    private readonly IFounderRepository _repository;

    public GetFounderByIdQueryHandler(IFounderRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetFounderByIdResponse> Handle(GetFounderByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id, cancellationToken);

        var response = result.Adapt<GetFounderByIdResponse>();

        return response;
    }
}
