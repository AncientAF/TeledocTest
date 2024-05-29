namespace TeledocTest.Application.Founders.UpdateFounder;
public record UpdateFounderCommand(Guid Id, string TaxId, string Name, string MiddleName, string LastName, IEnumerable<Client> LegalEntities) : ICommand<UpdateFounderResponse>;
public record UpdateFounderResponse(Guid Id, string TaxId, string Name, string MiddleName, string LastName, IEnumerable<Client> LegalEntities, DateTime CreatedAt, DateTime UpdatedAt);
