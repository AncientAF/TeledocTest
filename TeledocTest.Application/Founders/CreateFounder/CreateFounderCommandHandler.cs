
namespace TeledocTest.Application.Founders.CreateFounder;
public class CreateFounderCommandHandler : ICommandHandler<CreateFounderCommand, CreateFounderResponse>
{
    private readonly IFounderRepository _repository;

    public CreateFounderCommandHandler(IFounderRepository repository)
    {
        _repository = repository;
    }

    public async Task<CreateFounderResponse> Handle(CreateFounderCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.Create(request.Adapt<Founder>(), cancellationToken);

        var response = result.Adapt<CreateFounderResponse>();

        return response;
    }
}
