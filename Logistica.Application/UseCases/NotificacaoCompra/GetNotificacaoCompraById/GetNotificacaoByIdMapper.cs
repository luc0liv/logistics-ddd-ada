using AutoMapper;

public sealed class GetNotificacaoByIdMapper : Profile
{
    public GetNotificacaoByIdMapper()
    {
        CreateMap<NotificacaoCompra, GetNotificacaoByIdResponse>();
    }
}
