namespace TeledocTest.Application.Clients;
public record CreateClientCommand(string TaxId, string Name, ClientType Type, IList<Guid>? FoundersIds) : ICommand<CreateClientResponse>;
public record CreateClientResponse(Guid Id);
