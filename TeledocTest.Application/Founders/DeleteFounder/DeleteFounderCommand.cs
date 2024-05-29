namespace TeledocTest.Application.Founders.DeleteFounder;
public record DeleteFounderCommand(Guid Id) : ICommand<DeleteFounderResponse>;
public record DeleteFounderResponse(bool IsSuccess);
