using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<NotificacaoCompra> NotificacaoCompras { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Destinatario> Destinatarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //modelBuilder.Entity<User>().Ignore(user => user.Perfil);
        //modelBuilder.Entity<frete>()
        //.HasOne(frete => frete.Destinatario) // quando possuir varios perfis
        //.whitOne(destinario => frete.Destinario) // associando o perfil ao usuario
        //.HasForeingnKey(Destinatario => destinario.DestinatarioID); // e o que eu to dizendo que é o N do relacionamento *-//
    }
}
