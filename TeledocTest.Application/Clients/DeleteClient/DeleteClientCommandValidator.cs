namespace TeledocTest.Application.Clients;
public class DeleteClientCommandValidator : AbstractValidator<DeleteClientCommand>
{
    public DeleteClientCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotEmpty().WithMessage("Идентификатор клиента не может быть пустым");
    }
}
