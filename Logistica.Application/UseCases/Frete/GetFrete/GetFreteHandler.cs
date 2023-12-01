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
        var dataPrevista = shipping.DataPrevista.AddDays(7);

        var formattedFrete = new GetFreteResponse
        {
            Valor = shipping.Valor,
            DataPrevista = dataPrevista.ToString("dd/MM/yyyy"),
        };
        return _mapper.Map<GetFreteResponse>(formattedFrete);
    }
}