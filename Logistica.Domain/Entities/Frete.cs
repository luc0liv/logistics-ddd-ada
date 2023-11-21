public class Frete : BaseEntity
{
    public Endereco Endereco { get; set; }
    public EShippingStatus StatusEntrega { get; set; }
    public decimal Valor { get; set; }
    public DateTimeOffset DataPrevista { get; set; }
}
