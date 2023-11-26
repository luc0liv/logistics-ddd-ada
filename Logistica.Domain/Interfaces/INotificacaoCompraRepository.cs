public interface INotificacaoCompraRepository : IBaseRepository<NotificacaoCompra>
{
    Task<NotificacaoCompra> GetById(Guid Id, CancellationToken cancellationToken);
    Task<List<NotificacaoCompra>> GetNotifications(CancellationToken cancellationToken);
}

