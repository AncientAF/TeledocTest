namespace TeledocTest.Application.Founders;
public record GetFoundersQuery() : IQuery<GetFoundersResponse>;
public record GetFoundersResponse(IEnumerable<FounderWithRelationsResponse> Founders);
public record FounderWithRelationsResponse(Guid Id, string TaxId, string Name, string MiddleName, string LastName, IEnumerable<ClientResponse> LegalEntities, DateTime UpdatedAt, DateTime CreatedAt);