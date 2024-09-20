using CommunityToolkit.Mvvm.ComponentModel;
using MauiExample.Services.Navigation;

namespace MauiExample.ViewModels;

public abstract partial class BaseViewModel(INavigationService navigationService) : ObservableObject
{
    protected INavigationService Navigation { get; } = navigationService;

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    private bool _isBusy;

    public bool IsNotBusy => !IsBusy;
}