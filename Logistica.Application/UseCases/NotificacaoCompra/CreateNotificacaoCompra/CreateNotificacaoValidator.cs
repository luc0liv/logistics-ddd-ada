using FluentValidation;


public sealed class CreateNotificacaoValidator : AbstractValidator<CreateNotificacaoRequest>
{
    public CreateNotificacaoValidator()
    {
        //RuleFor(x => x.Destinatario.CepDestinatario)
        //    .NotEmpty().WithMessage("O CEP não pode estar vazio.")
        //    .Length(8).WithMessage("O CEP deve ter 8 dígitos.")
        //    .Matches("^[0-9]+$").WithMessage("O CEP deve conter apenas números.");
        //RuleFor(x => x.Destinatario.EnderecoDestinatario.Numero).GreaterThanOrEqualTo(0).NotNull();
        //RuleFor(x => x.Destinatario.EnderecoDestinatario.Logradouro).NotEmpty();
        //RuleFor(x => x.Destinatario.EnderecoDestinatario.Bairro).NotEmpty();
        //RuleFor(x => x.Destinatario.EnderecoDestinatario.Cidade).NotEmpty();
        //RuleFor(x => x.Destinatario.EnderecoDestinatario.UF).NotEmpty();
    }
}
