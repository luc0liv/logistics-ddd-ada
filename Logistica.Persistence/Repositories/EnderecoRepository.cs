public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
{
    public EnderecoRepository(AppDbContext context) : base(context)
    {

    }

}
