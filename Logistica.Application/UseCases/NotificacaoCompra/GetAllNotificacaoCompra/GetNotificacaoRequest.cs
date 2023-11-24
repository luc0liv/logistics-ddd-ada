using MediatR;

public sealed record GetNotificacaoRequest : IRequest<List<GetNotificacaoResponse>>;
