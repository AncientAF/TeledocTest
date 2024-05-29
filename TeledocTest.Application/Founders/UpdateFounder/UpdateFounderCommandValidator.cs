namespace TeledocTest.Application.Founders;
public class UpdateFounderCommandValidator : AbstractValidator<UpdateFounderCommand>
{
    public UpdateFounderCommandValidator()
    {
        RuleFor(f => f.TaxId)
            .MinimumLength(12).WithMessage("ИНН не может быть короче 12 символов")
            .Must(t => long.TryParse(t, out _)).WithMessage("ИНН должен содержать только числа")
            .When(f => !String.IsNullOrEmpty(f.TaxId));
    }
}
