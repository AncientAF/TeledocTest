namespace TeledocTest.Application.Founders;
public class DeleteFounderCommandValidator : AbstractValidator<DeleteFounderCommand>
{
    public DeleteFounderCommandValidator()
    {
        RuleFor(f => f.Id)
            .NotEmpty().WithMessage("Идентификатор учредителя не может быть пустым");
    }
}
