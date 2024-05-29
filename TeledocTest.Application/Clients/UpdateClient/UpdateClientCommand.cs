namespace TeledocTest.Application.Clients.UpdateClient;
public record UpdateClientCommand(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<Founder> Founders) : ICommand<UpdateClientResponse>;
public record UpdateClientResponse(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<Founder> Founders, DateTime CreatedAt, DateTime UpdatedAt);
