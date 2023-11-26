using AutoMapper;

public sealed class GetNotificacaoByIdMapper : Profile
{
    public GetNotificacaoByIdMapper()
    {
        CreateMap<GetNotificacaoByIdRequest, NotificacaoCompra>();
        CreateMap<NotificacaoCompra, GetNotificacaoByIdResponse>();
    }
}
