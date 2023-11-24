public class NotificacaoCompraRepository : BaseRepository<NotificacaoCompra>, INotificacaoCompraRepository
{
    public NotificacaoCompraRepository(AppDbContext context) : base(context)
    {

    }

}
