using Avalonia;
using System;
using Microsoft.Extensions.DependencyInjection;
using Signal.Desktop.Extentions;

namespace Signal.Desktop;

sealed class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }
    
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        ServiceProvider = services.BuildServiceProvider();
        
        return AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
    }
    
    private static void ConfigureServices(IServiceCollection services)
    {
        services.StaticServices();
        
        services.AddConvertors();
        
        services.AddServices();
    
        services.AddViewModelsAndViews();
    }
}