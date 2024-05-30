namespace TeledocTest.Application.Founders;
public record ClientResponse(Guid Id, string TaxId, string Name, ClientType Type, DateTime UpdatedAt, DateTime CreatedAt);
