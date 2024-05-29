namespace TeledocTest.Application.Founders.DeleteFounder;
public class DeleteFounderCommandHandler : ICommandHandler<DeleteFounderCommand, DeleteFounderResponse>
{
    private readonly IFounderRepository _repository;

    public DeleteFounderCommandHandler(IFounderRepository repository)
    {
        _repository = repository;
    }

    public async Task<DeleteFounderResponse> Handle(DeleteFounderCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.Delete(request.Id, cancellationToken);

        var response = new DeleteFounderResponse(result);

        return response;
    }
}
