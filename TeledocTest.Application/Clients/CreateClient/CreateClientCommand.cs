namespace TeledocTest.Application.Clients.CreateClient;
public record CreateClientCommand(string TaxId, string Name, ClientType Type, IEnumerable<Founder> Founders) : ICommand<CreateClientResponse>;
public record CreateClientResponse(Guid Id);
