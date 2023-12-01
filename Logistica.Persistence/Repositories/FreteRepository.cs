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
        Frete frete = new Frete()
        {
            Valor = 20,
            DataPrevista = DateTimeOffset.Now,
        };
        return Task.FromResult(frete);
        //var entityEntry = await _context.Fretes.AddAsync(frete);
        //await _context.SaveChangesAsync(); // Salvar alterações no banco de dados

        //return entityEntry.Entity;
    }
}