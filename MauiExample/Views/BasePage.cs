using MauiExample.ViewModels;

namespace MauiExample.Views;

public abstract class BasePage : ContentPage
{
    protected BasePage(BaseViewModel viewModel)
    {
        BindingContext = viewModel;
    }
}