using AutoMapper;
using MediatR;


public class CreateNotificacaoHandler :
       IRequestHandler<CreateNotificacaoRequest, CreateNotificacaoResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly INotificacaoCompraRepository _NotificacaoRepository;
    private readonly IMapper _mapper;

    public CreateNotificacaoHandler(IUnitOfWork unitOfWork,
        INotificacaoCompraRepository notificacaoRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _NotificacaoRepository = notificacaoRepository;
        _mapper = mapper;
    }

    public async Task<CreateNotificacaoResponse> Handle(CreateNotificacaoRequest request,
        CancellationToken cancellationToken)
    {
        var notificacao = _mapper.Map<NotificacaoCompra>(request);

        _NotificacaoRepository.Create(notificacao);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateNotificacaoResponse>(notificacao);
    }
}

