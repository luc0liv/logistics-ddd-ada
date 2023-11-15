public class Produto : BaseEntity
{
    public string NomeProduto { get; set; }
    public decimal PesoProduto { get; set; }

    public int Quantidade { get; set; }
}
