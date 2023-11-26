using FluentValidation;


public sealed class CreateNotificacaoValidator : AbstractValidator<CreateNotificacaoRequest>
{
    public CreateNotificacaoValidator()
    {
        RuleForEach(x => x.Produtos).Where(x => x != null)
                                    .ChildRules(prod =>
        {
            prod.RuleFor(p => p.NomeProduto).NotEmpty();
            prod.RuleFor(p => p.PesoProduto).GreaterThan(0);
            prod.RuleFor(p => p.PrecoProduto).GreaterThan(0);
            prod.RuleFor(p => p.Quantidade).GreaterThan(0);
        });
        RuleFor(x => x.Destinatario.CepDestinatario)
            .NotEmpty().WithMessage("O CEP não pode estar vazio.")
            .Length(8).WithMessage("O CEP deve ter 8 dígitos.")
            .Matches("^[0-9]+$").WithMessage("O CEP deve conter apenas números.");
        RuleFor(x => x.Destinatario.EnderecoDestinatario.Numero).GreaterThanOrEqualTo(0).NotNull();
        RuleFor(x => x.Destinatario.EnderecoDestinatario.Logradouro).NotEmpty();
        RuleFor(x => x.Destinatario.EnderecoDestinatario.Bairro).NotEmpty();
        RuleFor(x => x.Destinatario.EnderecoDestinatario.Cidade).NotEmpty();
        RuleFor(x => x.Destinatario.EnderecoDestinatario.UF).NotEmpty();
    }
}
