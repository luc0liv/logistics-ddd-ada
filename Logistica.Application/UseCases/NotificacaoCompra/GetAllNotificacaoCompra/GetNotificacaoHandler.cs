using MediatR;
using AutoMapper;


public sealed class GetNotificacaoHandler : IRequestHandler<GetNotificacaoRequest, List<GetNotificacaoResponse>>
{
    private readonly INotificacaoCompraRepository _NotificacaoRepository;
    private readonly IMapper _mapper;

    public GetNotificacaoHandler(INotificacaoCompraRepository NotificacaoRepository, IMapper mapper)
    {
        _NotificacaoRepository = NotificacaoRepository;
        _mapper = mapper;
    }

    public async Task<List<GetNotificacaoResponse>> Handle(GetNotificacaoRequest request, CancellationToken cancellationToken)
    {
        var notificacoes = await _NotificacaoRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetNotificacaoResponse>>(notificacoes);
    }
}