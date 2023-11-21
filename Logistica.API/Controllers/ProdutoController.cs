using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
    public class ProdutoController : ControllerBase
    {
        IMediator _mediator;

        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProdutoRequest request)
        {
            try
            {
                var product = await _mediator.Send(request);
                return Ok(product);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    [HttpGet]
    public async Task<ActionResult<List<GetProdutoResponse>>> GetAll(CancellationToken cancellationToken)
    {
        try
        {
            var products = await _mediator.Send(new GetProdutoRequest(), cancellationToken);
            return Ok(products);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
