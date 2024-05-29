namespace TeledocTest.Application.Founders;
public record CreateFounderCommand(string TaxId, string Name, string MiddleName, string LastName, IList<Guid>? LegalEntitiesIds) : ICommand<CreateFounderResponse>;
public record CreateFounderResponse(Guid Id);
