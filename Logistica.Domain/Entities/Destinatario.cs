public class Destinatario : BaseEntity
{
    public string NomeDestinatario { get; set; }
    public string EnderecoDestinatario { get; set; }
    public string CepDestinatario {  get; set; }

    private Produto IdProduto;
}