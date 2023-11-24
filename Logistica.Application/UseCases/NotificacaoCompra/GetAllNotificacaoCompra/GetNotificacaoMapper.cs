using AutoMapper;

public sealed class GetNotificacaoMapper : Profile
{
    public GetNotificacaoMapper() { 
        CreateMap<NotificacaoCompra, GetNotificacaoResponse>();
    }
}
