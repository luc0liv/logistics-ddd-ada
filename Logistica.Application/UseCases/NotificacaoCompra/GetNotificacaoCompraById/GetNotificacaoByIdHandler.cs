using MediatR;
using AutoMapper;


public sealed class GetNotificacaoByIdHandler : IRequestHandler<GetNotificacaoByIdRequest, GetNotificacaoByIdResponse>
{
    private readonly INotificacaoCompraRepository _NotificacaoRepository;
    private readonly IMapper _mapper;

    public GetNotificacaoByIdHandler(INotificacaoCompraRepository NotificacaoRepository, IMapper mapper)
    {
        _NotificacaoRepository = NotificacaoRepository;
        _mapper = mapper;
    }

    public async Task<GetNotificacaoByIdResponse> Handle(GetNotificacaoByIdRequest request, CancellationToken cancellationToken)
    {
        Console.WriteLine("CHAMOU HANDLER");
        var notificacoes = await _NotificacaoRepository.GetById(request.Id, cancellationToken);
        return _mapper.Map<GetNotificacaoByIdResponse>(notificacoes);
    }
}