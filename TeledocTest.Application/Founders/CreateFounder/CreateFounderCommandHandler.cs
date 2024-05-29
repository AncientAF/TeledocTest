namespace TeledocTest.Application.Founders;
public class CreateFounderCommandHandler : ICommandHandler<CreateFounderCommand, CreateFounderResponse>
{
    private readonly IFounderRepository _repository;

    public CreateFounderCommandHandler(IFounderRepository repository)
    {
        _repository = repository;
    }

    public async Task<CreateFounderResponse> Handle(CreateFounderCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.Create(request.Adapt<Founder>(), request.LegalEntitiesIds, cancellationToken);

        var response = new CreateFounderResponse(result);

        return response;
    }
}
