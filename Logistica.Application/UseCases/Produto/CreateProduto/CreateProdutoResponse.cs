public sealed record CreateProdutoResponse
    {
        public Guid Id { get; set; }
        public string? NomeProduto { get; set; }
        public decimal PesoProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public int Quantidade { get; set; }
    }
