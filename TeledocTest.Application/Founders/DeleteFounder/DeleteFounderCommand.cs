namespace TeledocTest.Application.Founders;
public record DeleteFounderCommand(Guid Id) : ICommand<DeleteFounderResponse>;
public record DeleteFounderResponse(bool IsSuccess);
