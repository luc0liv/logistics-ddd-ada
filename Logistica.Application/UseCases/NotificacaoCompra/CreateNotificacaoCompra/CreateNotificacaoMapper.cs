using AutoMapper;


public sealed class CreateNotificacaoCompraMapper : Profile
{
    public CreateNotificacaoCompraMapper()
    {
        CreateMap<CreateNotificacaoRequest, NotificacaoCompra>();
        CreateMap<NotificacaoCompra, CreateNotificacaoResponse>();
    }
}
