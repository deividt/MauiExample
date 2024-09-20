using CommunityToolkit.Maui;
using MauiExample.Extensions;
using Microsoft.Extensions.Logging;

namespace MauiExample;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .RegisterServices()
            .RegisterPages();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}