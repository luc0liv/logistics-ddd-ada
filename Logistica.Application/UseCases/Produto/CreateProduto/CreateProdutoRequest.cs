using MediatR;

public sealed record CreateProdutoRequest(
        string NomeProduto, decimal PesoProduto, decimal PrecoProduto, int Quantidade) :
            IRequest<CreateProdutoResponse>;
