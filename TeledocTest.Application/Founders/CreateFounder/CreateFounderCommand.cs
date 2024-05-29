namespace TeledocTest.Application.Founders.CreateFounder;
public record CreateFounderCommand(string TaxId, string Name, string MiddleName, string LastName, IEnumerable<Client> LegalEntities) : ICommand<CreateFounderResponse>;
public record CreateFounderResponse(Guid Id, string TaxId, string Name, string MiddleName, string LastName, IEnumerable<Client> LegalEntities, DateTime CreatedAt, DateTime UpdatedAt);
