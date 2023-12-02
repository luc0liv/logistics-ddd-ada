using AutoMapper;

public sealed class GetFreteMapper : Profile
{
    public GetFreteMapper()
    {
        CreateMap<GetFreteRequest, Frete>();
        CreateMap<Frete, GetFreteResponse>();
    }
}
