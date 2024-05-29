namespace TeledocTest.Application.Clients;
public record GetClientsQuery() : IQuery<GetClientsResponse>;
public record GetClientsResponse(IEnumerable<Client> Clients);
