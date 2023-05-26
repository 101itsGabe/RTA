using Library.App.Models;
using RTA.ViewModels;
using RTA.XamlPages;
namespace RTA.XamlPages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

}

