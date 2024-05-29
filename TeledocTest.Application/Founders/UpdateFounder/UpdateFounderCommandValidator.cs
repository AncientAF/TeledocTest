namespace TeledocTest.Application.Founders.UpdateFounder;
public class UpdateFounderCommandValidator : AbstractValidator<UpdateFounderCommand>
{
    public UpdateFounderCommandValidator()
    {
        RuleFor(f => f.TaxId)
            .MinimumLength(12).WithMessage("ИНН не может быть короче 12 символов")
            .Must(t => int.TryParse(t, out _)).WithMessage("ИНН должен содержать только числа")
            .When(f => !String.IsNullOrEmpty(f.TaxId));
    }
}
