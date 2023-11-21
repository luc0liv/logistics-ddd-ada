using MediatR;

public sealed record CreateProdutoRequest(
        string Nome, decimal Peso, decimal Preco, int Quantidade) :
            IRequest<CreateProdutoResponse>;
