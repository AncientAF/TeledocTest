using TeledocTest.Application.Clients.CreateClient;

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
        var result = await _repository.Create(request.Adapt<Client>(), cancellationToken);

        var response = new CreateClientResponse(result);

        return response;
    }
}
