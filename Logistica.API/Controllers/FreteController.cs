using MediatR;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class FreteController : ControllerBase
{
    IMediator _mediator;
    private readonly ILogger<FreteController> _logger;

    public FreteController(IMediator mediator, ILogger<FreteController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet("{cep}")]
    public async Task<ActionResult<GetFreteResponse>>
        GetShipmentValue(string cep, CancellationToken cancellationToken)
    {
        try
        {
            var request = new GetFreteRequest(cep);
            var ship = await _mediator.Send(request, cancellationToken);
            return Ok(ship);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
