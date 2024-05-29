namespace TeledocTest.Application.Founders;
public class CreateFounderCommandValidator : AbstractValidator<CreateFounderCommand>
{
    public CreateFounderCommandValidator()
    {
        RuleFor(f => f.TaxId)
            .NotEmpty().WithMessage("ИНН не может быть пустым")
            .Length(12).WithMessage("ИНН не может иметь длину отличную от 12")
            .Must(t => long.TryParse(t, out _)).WithMessage("ИНН должен содержать только числа");

        RuleFor(f => f.Name)
            .NotEmpty().WithMessage("Имя учредителя не может быть пустым");
        RuleFor(f => f.MiddleName)
            .NotEmpty().WithMessage("Отчество учредителя не может быть пустым");
        RuleFor(f => f.LastName)
            .NotEmpty().WithMessage("Фамилия учредителя не может быть пустым");
    }
}
