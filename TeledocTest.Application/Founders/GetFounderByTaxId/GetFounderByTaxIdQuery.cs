namespace TeledocTest.Application.Founders;
public record GetFounderByTaxIdQuery(string TaxId) : IQuery<GetFounderByTaxIdResponse>;
public record GetFounderByTaxIdResponse(Guid Id, string TaxId, string Name, string MiddleName, string LastName, IEnumerable<ClientResponse> LegalEntities, DateTime CreatedAt, DateTime UpdatedAt);

