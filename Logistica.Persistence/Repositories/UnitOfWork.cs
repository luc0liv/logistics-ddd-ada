
// gerencia e commita as transações no banco de dados
public class UnitOfWork : IUnitOfWork
{

    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context; // representação do DB
    }

    public async Task Commit(CancellationToken cancellationToken)
    {
        // método que commita e salva alterações no banco
        await _context.SaveChangesAsync(cancellationToken);
    }
}