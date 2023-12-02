using MediatR;
using AutoMapper;
using System.Globalization;

public sealed class GetFreteHandler : IRequestHandler<GetFreteRequest, GetFreteResponse>
{
    private readonly IFreteRepository _FreteRepository;
    private readonly IMapper _mapper;

    public GetFreteHandler(IFreteRepository FreteRepository, IMapper mapper)
    {
        _FreteRepository = FreteRepository;
        _mapper = mapper;
    }

    public async Task<GetFreteResponse> Handle(GetFreteRequest request, CancellationToken cancellationToken)
    {
        var shipping = await _FreteRepository.CalculateShipment(request.Cep, cancellationToken);
        var expectedDate = shipping.DataPrevista;

        GetFreteResponse formattedShipping = new GetFreteResponse
        {
            Valor = shipping.Valor,
            DataPrevista = expectedDate.ToString("dd/MM/yyyy"),
        };
        return _mapper.Map<GetFreteResponse>(formattedShipping);
    }
}