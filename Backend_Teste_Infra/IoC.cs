using Backend_Teste_Domain.Interfaces;
using Backend_Teste_Domain.Services;
using Backend_Teste_Infra.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Backend_Teste_Infra
{
    public static class IoC
	{
		public static IServiceCollection ConfigureContainer(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IAcoesService, AcoesService>();

			var connectionString = configuration.GetConnectionString("MySql");

			services.AddScoped<IAcoesRepository>(_ => new AcoesRepository(connectionString));

			return services;
		}
	}
}
