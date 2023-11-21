using AutoMapper;


public sealed class CreateProdutoMapper : Profile
{
    public CreateProdutoMapper()
    {
        CreateMap<CreateProdutoRequest, Produto>();
        CreateMap<Produto, CreateProdutoResponse>();
    }
}

