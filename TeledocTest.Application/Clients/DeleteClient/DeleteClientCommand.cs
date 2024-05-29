namespace TeledocTest.Application.Clients.DeleteClient;
public record DeleteClientCommand(Guid Id) : ICommand<DeleteClientResponse>;
public record DeleteClientResponse(bool IsSuccess);