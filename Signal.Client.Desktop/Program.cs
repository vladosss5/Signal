using Avalonia;
using System;
using Microsoft.Extensions.DependencyInjection;
using Signal.Client.Desktop.Extensions;

namespace Signal.Client.Desktop;

sealed class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }
    
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    private static AppBuilder BuildAvaloniaApp()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        ServiceProvider = services.BuildServiceProvider();
        
        return AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.StaticServices();
        
        services.AddConvertors();
        
        services.AddServices();
    
        services.AddViewModelsAndViews();
    }
}