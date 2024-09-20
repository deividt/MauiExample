using MauiExample.ViewModels;

namespace MauiExample.Views;

public partial class MainPage : BasePage
{
    public MainPage(MainViewModel viewModel) : base(viewModel)
    {
        InitializeComponent();
    }
}