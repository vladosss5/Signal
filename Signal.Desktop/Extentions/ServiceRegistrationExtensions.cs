using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Signal.Desktop.ViewModels;
using Signal.Desktop.Views;

namespace Signal.Desktop.Extentions;

public static class ServiceRegistrationExtensions
{
    public static void StaticServices(this IServiceCollection services)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        
        var connectionString = configuration.GetConnectionString("DefaultConnection");
    
        if (string.IsNullOrEmpty(connectionString))
            throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    
        // services.AddDbContext<DataContext>(options => 
        //     options.UseNpgsql(connectionString),
        //     contextLifetime: ServiceLifetime.Transient);
        
    }
    
    public static void AddConvertors(this IServiceCollection services)
    {
        // services.AddSingleton<DateTimeFormatConverter>();
    }
    
    public static void AddServices(this IServiceCollection services)
    {
        // services.AddSingleton<IWindowService, WindowService>();
    }
    
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