﻿namespace TeledocTest.Application.Clients.UpdateClient;
public class UpdateClientCommandValidator : AbstractValidator<UpdateClientCommand>
{
    public UpdateClientCommandValidator()
    {
        RuleFor(c => c.TaxId)
            .MinimumLength(10).WithMessage("ИНН не может быть короче 10 символов")
            .Must(t => int.TryParse(t, out _)).WithMessage("ИНН должен содержать только числа")
            .When(c => !String.IsNullOrEmpty(c.TaxId));

        RuleFor(c => c.TaxId).Length(10).When(c => c.Type == ClientType.LegalEntity).WithMessage("ИНН юридического лица обязан быть длиной в 10 символов").When(c => !String.IsNullOrEmpty(c.TaxId));
        RuleFor(c => c.TaxId).Length(12).When(c => c.Type == ClientType.EntrepreneurialEntity).WithMessage("ИНН физического лица обязан быть длиной в 12 символов").When(c => !String.IsNullOrEmpty(c.TaxId));

        RuleFor(c => c.Type)
            .IsInEnum().WithMessage("Недопустимый тип клиента");

        RuleFor(c => c.Founders).Empty().When(c => c.Type == ClientType.EntrepreneurialEntity);
    }
}
