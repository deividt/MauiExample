using CommunityToolkit.Mvvm.ComponentModel;
using MauiExample.Services.Navigation;
using MauiExample.ViewModels;
using MauiExample.Views;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MauiExample.Extensions;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.TryAddSingleton<INavigationService, NavigationService>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
    {
        return mauiAppBuilder
            .AddPage<MainPage, MainViewModel>()
            .AddPage<DefaultPage, DefaultPageViewModel>()
            .AddPage<AppShell>();
    }

    private static MauiAppBuilder AddPage<TPage, TViewModel>(this MauiAppBuilder mauiAppBuilder)
        where TPage : Page where TViewModel : ObservableObject
    {
        mauiAppBuilder.Services.TryAddTransient<TPage>();
        mauiAppBuilder.Services.TryAddTransient<TViewModel>();
        Routing.RegisterRoute(typeof(TPage).Name, typeof(TPage));

        return mauiAppBuilder;
    }

    private static MauiAppBuilder AddPage<TPage>(this MauiAppBuilder mauiAppBuilder)
        where TPage : Page
    {
        mauiAppBuilder.Services.TryAddTransient<TPage>();

        return mauiAppBuilder;
    }
}