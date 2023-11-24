using MediatR;

public sealed record GetNotificacaoByIdRequest(Guid Id) : IRequest<GetNotificacaoByIdResponse>;