
namespace TeledocTest.Application.Clients;
public class UpdateClientCommandHandler : ICommandHandler<UpdateClientCommand, UpdateClientResponse>
{
    private readonly IClientRepository _repository;

    public UpdateClientCommandHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<UpdateClientResponse> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.Update(request.Adapt<Client>(), request.FoundersIds, cancellationToken);

        var response = result.Adapt<UpdateClientResponse>();

        return response;
    }
}
