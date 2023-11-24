public class Destinatario : BaseEntity
{
    public string NomeDestinatario { get; set; }
    public Endereco EnderecoDestinatario { get; set; }
    public string CepDestinatario { get; set; }
}