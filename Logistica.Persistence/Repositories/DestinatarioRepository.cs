public class DestinatarioRepository : BaseRepository<Destinatario>, IDestinatarioRepository
    {
    public DestinatarioRepository(AppDbContext context) : base(context) { }
    }
