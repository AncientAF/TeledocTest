namespace TeledocTest.Application.Clients.GetClients;
public record GetClientsQuery() : IQuery<GetClientsResponse>;
public record GetClientsResponse(IEnumerable<Client> Clients);
