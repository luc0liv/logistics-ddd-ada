using AutoMapper;

public sealed class GetProdutoMapper : Profile
{
    public GetProdutoMapper()
    {
        CreateMap<Produto, GetProdutoResponse>();
    }
}