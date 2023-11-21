using MediatR;
using AutoMapper;


public sealed class GetProdutoHandler : IRequestHandler<GetProdutoRequest, List<GetProdutoResponse>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProdutoHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<List<GetProdutoResponse>> Handle(GetProdutoRequest request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetProdutoResponse>>(products);
    }
}