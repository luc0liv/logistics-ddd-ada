using MediatR;

public sealed record CreateNotificacaoRequest(
        List<Produto> Produtos, Destinatario Destinatario) :
            IRequest<CreateNotificacaoResponse>;
