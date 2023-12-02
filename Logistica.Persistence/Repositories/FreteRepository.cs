using System.Reflection.Metadata.Ecma335;

public class FreteRepository : BaseRepository<Frete>, IFreteRepository
{
    private readonly AppDbContext _context;
    public FreteRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public Task<Frete> CalculateShipment(string cep, CancellationToken cancellationToken)
    {
        Random randomValue = new Random();
        // O cálculo de frete é apenas uma simulação
        Frete frete = new Frete()
        {
            Valor = (decimal)(randomValue.Next(0, 100) * 0.25),
            DataPrevista = DateTimeOffset.Now.AddDays(randomValue.Next(0, 14)),
        };
        return Task.FromResult(frete);
    }
}