public sealed record GetNotificacaoByIdResponse
{   
    public readonly string Id;
    public Destinatario Destinatario { get; set; }
    public List<Produto> Produtos { get; set; }
}
