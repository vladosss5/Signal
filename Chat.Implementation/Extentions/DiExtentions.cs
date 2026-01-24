using Chat.Application.Interfaces.Repositories;
using Chat.Application.Interfaces.Services;
using Chat.Data.Context;
using Chat.Implementation.Repositories;
using Chat.Implementation.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.Implementation.Extentions;

/// <summary>
/// Регистрация компоненков в DI контейнере
/// </summary>
public static class DiExtentions
{
    /// <summary>
    /// Регистрация сервисов
    /// </summary>
    /// <param name="services">Контракт с сервисами</param>
    /// <returns>Расширенный контракт</returns>
    public static IServiceCollection RegistrationServices(this IServiceCollection services)
    {
        services.AddScoped<IAccountingService, AccountingService>();

        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }

    /// <summary>
    /// Регистрация контекста БД
    /// </summary>
    /// <param name="services">Контракт с сервисами</param>
    /// <returns>Расширенный контракт</returns>
    public static IServiceCollection RegistrationDataContext(this IServiceCollection services)
    {
        services.AddDbContext<SignalDBContext>();

        return services;
    }
}