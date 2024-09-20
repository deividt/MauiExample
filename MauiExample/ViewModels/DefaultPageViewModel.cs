using CommunityToolkit.Mvvm.Input;
using MauiExample.Services.Navigation;

namespace MauiExample.ViewModels;

public partial class DefaultPageViewModel(INavigationService navigationService) : BaseViewModel(navigationService)
{
    [RelayCommand]
    private async Task GoBack()
    {
        await Navigation.GoBackAsync();
    }
}