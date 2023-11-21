using FluentValidation;


public sealed class CreateProdutoValidator : AbstractValidator<CreateProdutoRequest>
{
    public CreateProdutoValidator()
    {
        RuleFor(x => x.Nome).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Peso).GreaterThan(0).NotNull();
        RuleFor(x => x.Preco).GreaterThan(0).NotNull();
        RuleFor(x => x.Quantidade).GreaterThan(0).NotNull();
    }
}
