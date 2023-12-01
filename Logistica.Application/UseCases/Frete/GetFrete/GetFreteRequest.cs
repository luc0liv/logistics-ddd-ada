using MediatR;

public sealed record GetFreteRequest(string Cep) : IRequest<GetFreteResponse>;