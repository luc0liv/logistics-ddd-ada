public sealed record GetProdutoResponse
{
    public Guid Id { get; set; }
    public string NomeProduto { get; set; }
    public decimal PrecoProduto { get; set; }
    public decimal PesoProduto { get; set; }

    public int Quantidade { get; set; }
}
