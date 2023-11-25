using Microsoft.EntityFrameworkCore;

public class NotificacaoCompraRepository : BaseRepository<NotificacaoCompra>, INotificacaoCompraRepository
{
    private readonly AppDbContext _context;
    public NotificacaoCompraRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<NotificacaoCompra> GetById(Guid Id, CancellationToken cancellationToken)
    {
        Console.WriteLine("CHAMOU REPOSITORY");
        return await _context.NotificacaoCompras
            .FirstOrDefaultAsync(n => n.Id.Equals(Id), cancellationToken);
    }

    public List<GetNotificacaoResponse> GetNotificacoes()
    {
        var query = _context.NotificacaoCompras
            .Join(_context.Destinatarios,
                n => n.Destinatario.Id,
                d => d.Id,
                (n, d) => new { NotificacaoCompra = n, Destinatario = d })
            .Select(result => new GetNotificacaoResponse
            {
                // Mapeie as propriedades conforme necessário
               Id = result.NotificacaoCompra.Id,
               Destinatario = result.NotificacaoCompra.Destinatario,
               Produtos = result.NotificacaoCompra.Produtos
            })
            .ToList();

        return query;
    }
}
