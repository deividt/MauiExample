using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiExample.Services.Navigation;

namespace MauiExample.ViewModels;

public partial class MainViewModel(INavigationService navigationService) : BaseViewModel(navigationService)
{
    [ObservableProperty] private int _count;

    [RelayCommand]
    private void IncrementCount()
    {
        Count++;
    }

    [RelayCommand]
    private async Task NextPage()
    {
        await Navigation.NavigateToAsync<DefaultPageViewModel>();
    }
}