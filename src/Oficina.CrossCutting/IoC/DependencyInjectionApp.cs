using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oficina.Application.Mappings;
using Oficina.Domain.Interfaces;
using Oficina.Infrastructure.Context;
using Oficina.Infrastructure.Repositories;

namespace Oficina.CrossCutting.IoC
{
    public static  class DependencyInjectionApp
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IFuncionarioRepositry, FuncionarioRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IMaoDeObraRepository, MaoDeObraRepository>();
            services.AddScoped<IPecaRepository, PecaRepository>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            
            return services;
        }
    }
}
