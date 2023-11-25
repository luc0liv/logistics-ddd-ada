using MediatR;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class NotificacaoCompraController : ControllerBase
{
    IMediator _mediator;
    private readonly ILogger<NotificacaoCompraController> _logger;

    public NotificacaoCompraController(IMediator mediator, ILogger<NotificacaoCompraController> logger)
    {
        _mediator = mediator;
        _logger = logger;
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

    [HttpGet("{id}")]
    public async Task<ActionResult<GetNotificacaoByIdResponse>>
        GetById(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var request = new GetNotificacaoByIdRequest(id);
            var notification = await _mediator.Send(request, cancellationToken);
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
