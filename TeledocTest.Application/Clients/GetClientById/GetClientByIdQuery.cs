namespace TeledocTest.Application.Clients;
public record GetClientByIdQuery(Guid Id) : IQuery<GetClientByIdResponse>;
public record GetClientByIdResponse(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<FounderResponse>? Founders, DateTime CreatedAt, DateTime UpdatedAt);
