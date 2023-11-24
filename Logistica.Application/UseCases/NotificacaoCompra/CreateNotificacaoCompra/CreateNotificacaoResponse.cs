public sealed record CreateNotificacaoResponse
{
    public Guid Id { get; set; }
    public Destinatario Destinatario { get; set; }
    public List<Produto> Produtos { get; set; }
}