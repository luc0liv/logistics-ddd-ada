using MediatR;

public sealed record GetProdutoRequest : IRequest<List<GetProdutoResponse>>;