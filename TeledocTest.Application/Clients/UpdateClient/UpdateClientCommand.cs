namespace TeledocTest.Application.Clients;
public record UpdateClientCommand(Guid Id, string? TaxId, string? Name, ClientType? Type, IList<Guid>? FoundersIds) : ICommand<UpdateClientResponse>;
public record UpdateClientResponse(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<FounderResponse>? Founders, DateTime CreatedAt, DateTime UpdatedAt);
//public record UpdateClientFounderReponse(Guid Id, string TaxId, string Name, string MiddleName, string LastName);
