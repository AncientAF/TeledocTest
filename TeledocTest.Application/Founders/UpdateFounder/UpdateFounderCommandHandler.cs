namespace TeledocTest.Application.Founders;
public class UpdateFounderCommandHandler : ICommandHandler<UpdateFounderCommand, UpdateFounderResponse>
{
    private readonly IFounderRepository _repository;

    public UpdateFounderCommandHandler(IFounderRepository repository)
    {
        _repository = repository;
    }

    public async Task<UpdateFounderResponse> Handle(UpdateFounderCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.Update(request.Adapt<Founder>(), request.LegalEntitiesIds, cancellationToken);

        var response = result.Adapt<UpdateFounderResponse>();

        return response;
    }
}
