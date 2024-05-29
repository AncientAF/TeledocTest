namespace TeledocTest.Application.Clients;
public record DeleteClientCommand(Guid Id) : ICommand<DeleteClientResponse>;
public record DeleteClientResponse(bool IsSuccess);