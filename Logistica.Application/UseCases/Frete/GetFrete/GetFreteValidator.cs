using FluentValidation;

public sealed class GetFreteValidator : AbstractValidator<GetFreteRequest>
{
    public GetFreteValidator()
    {
        RuleFor(x => x.Cep)
                    .NotEmpty().WithMessage("O CEP não pode estar vazio.")
                    .Length(8).WithMessage("O CEP deve ter 8 dígitos.")
                    .Matches("^[0-9]+$").WithMessage("O CEP deve conter apenas números.");
    }
}
