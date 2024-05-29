namespace TeledocTest.Application.Clients.CreateClient;
public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
{
    public CreateClientCommandValidator()
    {
        RuleFor(c => c.TaxId)
            .NotEmpty().WithMessage("ИНН не может быть пустым")
            .MinimumLength(10).WithMessage("ИНН не может быть короче 10 символов")
            .Must(t => int.TryParse(t, out _)).WithMessage("ИНН должен содержать только числа");

        RuleFor(c => c.TaxId).Length(10).When(c => c.Type == ClientType.LegalEntity).WithMessage("ИНН юридического лица обязан быть длиной в 10 символов");
        RuleFor(c => c.TaxId).Length(12).When(c => c.Type == ClientType.EntrepreneurialEntity).WithMessage("ИНН физического лица обязан быть длиной в 12 символов");

        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Наименование клиента не может быть пустым");

        RuleFor(c => c.Type)
            .IsInEnum().WithMessage("Недопустимый тип клиента");

        RuleFor(c => c.Founders).Empty().When(c => c.Type == ClientType.EntrepreneurialEntity);
    }
}
