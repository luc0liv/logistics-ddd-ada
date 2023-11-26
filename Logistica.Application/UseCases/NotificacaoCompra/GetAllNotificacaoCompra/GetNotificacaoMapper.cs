using AutoMapper;

public sealed class GetNotificacaoMapper : Profile
{
    public GetNotificacaoMapper() {
        CreateMap<NotificacaoCompra, GetNotificacaoResponse>()
    .ForMember(dest => dest.Destinatario, opt => opt.MapFrom(src => src.Destinatario))
    .ForMember(dest => dest.Produtos, opt => opt.MapFrom(src => src.Produtos));

    }
}
