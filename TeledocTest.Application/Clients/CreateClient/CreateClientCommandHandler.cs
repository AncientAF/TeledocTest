using TeledocTest.Application.Clients;

namespace TeledocTest.Application.Clients;

public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, CreateClientResponse>
{
    private readonly IClientRepository _repository;

    public CreateClientCommandHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<CreateClientResponse> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.Create(request.Adapt<Client>(), request.FoundersIds, cancellationToken);

        var response = new CreateClientResponse(result);

        return response;
    }
}
