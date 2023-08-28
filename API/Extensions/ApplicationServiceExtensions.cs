using Core.Interfaces;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace API.Extensions;
public static class ApplicationServiceExtensions
{
    public static void ConfigureCors (this IServiceCollection services) =>
        services.AddCors (options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()    //WithOrigins("https://domini.com")
                .AllowAnyMethod()           //WithMethods(*GET", "POST")
                .AllowAnyHeader());         //WithHeaders(*accept*, "conten-type")
        });

    public static void AddAplicacionServices (this IServiceCollection services){
        //services.AdScoped<IPaisInterface,PaisRepository>();
        //services.AddScoped<ITipoPersona, TipoPersonaRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
