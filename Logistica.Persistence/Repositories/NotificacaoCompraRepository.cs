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
        var query = await _context.NotificacaoCompras
            .Join(_context.Destinatarios,
                n => n.Destinatario.Id,
                d => d.Id,
                (n, d) => new { NotificacaoCompra = n, Destinatario = d })
            .Select(result => new NotificacaoCompra
            {
                Id = result.NotificacaoCompra.Id,
                Destinatario = new Destinatario
                {
                    Id = result.Destinatario.Id,
                    NomeDestinatario = result.Destinatario.NomeDestinatario,
                    CepDestinatario = result.Destinatario.CepDestinatario,
                    EnderecoDestinatario = result.Destinatario.EnderecoDestinatario,
                },
                Produtos = result.NotificacaoCompra.Produtos
            })
            .FirstOrDefaultAsync(n => n.Id.Equals(Id), cancellationToken);
        return query;
    }

    public async Task<List<NotificacaoCompra>> GetNotifications(CancellationToken cancellationToken)
    {
        var query = await _context.NotificacaoCompras
            .Join(_context.Destinatarios,
                n => n.Destinatario.Id,
                d => d.Id,
                (n, d) => new { NotificacaoCompra = n, Destinatario = d })
            .Select(result => new NotificacaoCompra
            {
               Id = result.NotificacaoCompra.Id,
               Destinatario = new Destinatario
               {
                   Id = result.Destinatario.Id,
                   NomeDestinatario = result.Destinatario.NomeDestinatario,
                   CepDestinatario = result.Destinatario.CepDestinatario,
                   EnderecoDestinatario = result.Destinatario.EnderecoDestinatario,
               },
               Produtos = result.NotificacaoCompra.Produtos
            })
            .ToListAsync(cancellationToken);

        return query;
    }
}
