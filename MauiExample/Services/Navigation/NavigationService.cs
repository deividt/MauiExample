using System.Web;
using MauiExample.ViewModels;

namespace MauiExample.Services.Navigation;

public class NavigationService : INavigationService
{
    public async Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel
        => await InternalNavigateToAsync(typeof(TViewModel), null, false);

    public async Task NavigateToAsync<TViewModel>(bool isAbsoluteRoute) where TViewModel : BaseViewModel
        => await InternalNavigateToAsync(typeof(TViewModel), null, isAbsoluteRoute);

    public async Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel
        => await InternalNavigateToAsync(typeof(TViewModel), parameter, false);

    public async Task GoBackAsync()
        => await Shell.Current.GoToAsync("..");

    private async Task InternalNavigateToAsync(Type viewModelType, object parameter, bool isAbsoluteRoute = false)
    {
        var viewName = viewModelType.Name?.Replace("ViewModels", "Views").Replace("ViewModel", "");
        var absolutePrefix = isAbsoluteRoute ? "///" : string.Empty;

        if (parameter != null)
        {
            await Shell.Current.GoToAsync(
                $"{absolutePrefix}{viewName}?id={HttpUtility.UrlEncode(parameter.ToString())}");
            return;
        }

        await Shell.Current.GoToAsync($"{absolutePrefix}{viewName}");
    }
}