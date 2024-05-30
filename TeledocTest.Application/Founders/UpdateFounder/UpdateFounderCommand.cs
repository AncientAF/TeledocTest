namespace TeledocTest.Application.Founders;
public record UpdateFounderCommand(Guid Id, string? TaxId, string? Name, string? MiddleName, string? LastName, IList<Guid>? LegalEntitiesIds) : ICommand<UpdateFounderResponse>;
public record UpdateFounderResponse(Guid Id, string TaxId, string Name, string MiddleName, string LastName, IEnumerable<ClientResponse>? LegalEntities, DateTime CreatedAt, DateTime UpdatedAt);
