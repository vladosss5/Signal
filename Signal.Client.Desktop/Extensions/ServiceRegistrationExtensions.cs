using Microsoft.Extensions.DependencyInjection;
using Signal.Client.Desktop.ViewModels;
using Signal.Client.Desktop.Views;

namespace Signal.Client.Desktop.Extensions;

/// <summary>
/// Сервис-расширение для регистрации компонентов в DI контейнере.
/// </summary>
public static class ServiceRegistrationExtensions
{
    /// <summary>
    /// Добавляет статичные сервисы.
    /// </summary>
    /// <param name="services">Коллекция сервисов.</param>
    public static void StaticServices(this IServiceCollection services)
    {
        
    }
    
    /// <summary>
    /// Добавляет конвертеры.
    /// </summary>
    /// <param name="services">Коллекция сервисов.</param>
    public static void AddConvertors(this IServiceCollection services)
    {
        // services.AddSingleton<DateTimeFormatConverter>();
    }
    
    /// <summary>
    /// Добавляет сервисы.
    /// </summary>
    /// <param name="services">Коллекция сервисов.</param>
    public static void AddServices(this IServiceCollection services)
    {
        // services.AddSingleton<IWindowService, WindowService>();
    }
    
    /// <summary>
    /// Добавляет View и ViewModel.
    /// </summary>
    /// <param name="services">Коллекция сервисов.</param>
    public static void AddViewModelsAndViews(this IServiceCollection services)
    {
        // Windows
        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<MainWindow>();
        
        
        // Pages
        // services.AddTransient<EmployeesPageViewModel>();
        // services.AddTransient<EmployeesPageView>();
    }
}