public class ProdutoRepository : BaseRepository<Produto>, IProductRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context) {
        
    }

    }
