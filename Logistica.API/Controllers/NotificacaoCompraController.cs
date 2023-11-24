using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class NotificacaoCompraController : ControllerBase
{
    IMediator _mediator;
    public NotificacaoCompraController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateNotificacaoRequest request)
    {
        try
        {
            var notification = await _mediator.Send(request);
            return Ok(notification);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<GetNotificacaoResponse>>> GetAll(CancellationToken cancellationToken)
    {
        {
            try
            {
                var notifications = await _mediator.Send(new GetNotificacaoRequest(), cancellationToken);
                return Ok(notifications);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetNotificacaoByIdResponse>> Get(Guid id,CancellationToken cancellationToken)
    {
        {
            try
            {
                var notification = await _mediator.Send(id, cancellationToken);
                return Ok(notification);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
