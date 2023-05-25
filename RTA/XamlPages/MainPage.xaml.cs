using Library.App.Models;
using RTA.ViewModels;
using RTA.XamlPages;
namespace RTA;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }


    private async void RandomizerBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RandomizerPage());
    }
}

