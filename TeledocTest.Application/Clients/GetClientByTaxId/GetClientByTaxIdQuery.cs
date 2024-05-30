namespace TeledocTest.Application.Clients;
public record GetClientByTaxIdQuery(string TaxId) : IQuery<GetClientByTaxIdResponse>;
public record GetClientByTaxIdResponse(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<FounderResponse>? Founders, DateTime CreatedAt, DateTime UpdatedAt);
