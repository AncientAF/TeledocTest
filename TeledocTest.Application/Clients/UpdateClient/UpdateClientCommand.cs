namespace TeledocTest.Application.Clients;
public record UpdateClientCommand(Guid Id, string? TaxId, string? Name, ClientType? Type, IList<Guid>? FoundersIds) : ICommand<UpdateClientResponse>;
public record UpdateClientResponse(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<Founder>? Founders, DateTime CreatedAt, DateTime UpdatedAt);
