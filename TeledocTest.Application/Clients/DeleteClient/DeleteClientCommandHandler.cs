namespace TeledocTest.Application.Clients;
public class DeleteClientCommandHandler : ICommandHandler<DeleteClientCommand, DeleteClientResponse>
{
    private readonly IClientRepository _repository;

    public DeleteClientCommandHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<DeleteClientResponse> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.Delete(request.Id, cancellationToken);

        var response = new DeleteClientResponse(result);

        return response;
    }
}
