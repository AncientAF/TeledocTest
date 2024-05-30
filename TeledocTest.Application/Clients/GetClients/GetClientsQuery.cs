namespace TeledocTest.Application.Clients;
public record GetClientsQuery() : IQuery<GetClientsResponse>;
public record GetClientsResponse(IEnumerable<ClientWithRelationsResponse> Clients);
public record ClientWithRelationsResponse(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<FounderResponse> Founders, DateTime UpdatedAt, DateTime CreatedAt);


