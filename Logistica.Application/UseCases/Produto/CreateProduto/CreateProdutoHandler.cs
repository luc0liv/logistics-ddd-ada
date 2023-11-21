using AutoMapper;
using MediatR;


public class CreateProdutoHandler :
       IRequestHandler<CreateProdutoRequest, CreateProdutoResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _ProdutoRepository;
    private readonly IMapper _mapper;

    public CreateProdutoHandler(IUnitOfWork unitOfWork,
        IProductRepository ProdutoRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _ProdutoRepository = ProdutoRepository;
        _mapper = mapper;
    }

    public async Task<CreateProdutoResponse> Handle(CreateProdutoRequest request,
        CancellationToken cancellationToken)
    {
        var Produto = _mapper.Map<Produto>(request);

        _ProdutoRepository.Create(Produto);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateProdutoResponse>(Produto);
    }
}

