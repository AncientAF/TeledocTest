namespace TeledocTest.Application.Founders.CreateFounder;
public class CreateFounderCommandValidator : AbstractValidator<CreateFounderCommand>
{
    public CreateFounderCommandValidator()
    {
        RuleFor(f => f.TaxId)
            .NotEmpty().WithMessage("ИНН не может быть пустым")
            .MinimumLength(12).WithMessage("ИНН не может быть короче 12 символов")
            .Must(t => int.TryParse(t, out _)).WithMessage("ИНН должен содержать только числа");

        RuleFor(f => f.Name)
            .NotEmpty().WithMessage("Имя учредителя не может быть пустым");
        RuleFor(f => f.MiddleName)
            .NotEmpty().WithMessage("Отчество учредителя не может быть пустым");
        RuleFor(f => f.LastName)
            .NotEmpty().WithMessage("Фамилия учредителя не может быть пустым");
    }
}
