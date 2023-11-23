using FluentValidation;


public sealed class CreateProdutoValidator : AbstractValidator<CreateProdutoRequest>
{
    public CreateProdutoValidator()
    {
        RuleFor(x => x.NomeProduto).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.PesoProduto).GreaterThan(0).NotNull();
        RuleFor(x => x.PrecoProduto).GreaterThan(0).NotNull();
        RuleFor(x => x.Quantidade).GreaterThan(0).NotNull();
    }
}
