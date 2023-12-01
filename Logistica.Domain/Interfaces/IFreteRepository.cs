public interface IFreteRepository : IBaseRepository<Frete>
{
    Task<Frete> CalculateShipment(string cep, CancellationToken cancellationToken);
}

