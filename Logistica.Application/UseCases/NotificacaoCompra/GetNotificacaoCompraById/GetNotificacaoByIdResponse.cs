public class GetNotificacaoByIdResponse
{   
    public Guid Id;
    public Destinatario Destinatario { get; set; }
    public List<Produto> Produtos { get; set; }
}
