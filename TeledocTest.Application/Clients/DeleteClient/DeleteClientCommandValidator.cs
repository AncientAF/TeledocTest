namespace TeledocTest.Application.Clients.DeleteClient;
public class DeleteClientCommandValidator : AbstractValidator<DeleteClientCommand>
{
    public DeleteClientCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotEmpty().WithMessage("Идентификатор клиента не может быть пустым");
    }
}
