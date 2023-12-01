using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

public static class ServiceExtensions
{
 // configura a camada de persistencia no Entity framework

    public static void ConfigurePersistenceApp(
        this IServiceCollection services, IConfiguration configuration)
    {
        // recupera a string de conexão da camada de presentation /api

        var connectionString = configuration.GetConnectionString("Sqlite");

        // define provedor do BD

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(connectionString));

       // escopo da aplicação fica aqui:
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IProductRepository, ProdutoRepository>();
        services.AddScoped<INotificacaoCompraRepository, NotificacaoCompraRepository>();
        services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        services.AddScoped<IDestinatarioRepository, DestinatarioRepository>();
        services.AddScoped<IFreteRepository, FreteRepository>();
    }
}
