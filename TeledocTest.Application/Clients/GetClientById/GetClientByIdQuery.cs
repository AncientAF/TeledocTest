namespace TeledocTest.Application.Clients.GetClientById;
public record GetClientByIdQuery(Guid Id) : IQuery<GetClientByIdResponse>;
public record GetClientByIdResponse(Guid Id, string TaxId, string Name, ClientType Type, IEnumerable<Founder> Founders, DateTime CreatedAt, DateTime UpdatedAt);
