using Application.HikerElement;
using Domain.HikerElement;
using Domain.HikerElement.Repositories;
using Infrastructure.Repositories;
using Infrastructure.Repositories.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

public static class InfrastructureExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HikerElementContext>(
            o => o.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        services.AddScoped<IHikerElementRepository, HikerElementRepository>();
        services.AddDbContext<HikerElementContext>();
        services.AddScoped<IHikerElementProcess, HikerElementProcess>();
        return services;
    }
}