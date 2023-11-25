public interface INotificacaoCompraRepository : IBaseRepository<NotificacaoCompra>
{
    Task<NotificacaoCompra> GetById(Guid Id, CancellationToken cancellationToken);
}

