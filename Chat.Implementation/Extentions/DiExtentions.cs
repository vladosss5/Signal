using Chat.Application.Interfaces.Repositories;
using Chat.Application.Interfaces.Services;
using Chat.Implementation.Repositories;
using Chat.Implementation.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.Implementation.Extentions;

public static class DiExtentions
{
    public static IServiceCollection RegistrationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IAccountingService, AccountingService>();

        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
}