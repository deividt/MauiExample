using MauiExample.ViewModels;

namespace MauiExample.Views;

public partial class DefaultPage : BasePage
{
    public DefaultPage(DefaultPageViewModel viewModel) : base(viewModel)
    {
        InitializeComponent();
    }
}