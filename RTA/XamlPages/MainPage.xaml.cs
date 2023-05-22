using Library.App.Models;
using RTA.ViewModels;
using RTA.XamlPages;
namespace RTA;

public partial class MainPage : ContentPage
{
    TaskItem t = new TaskItem();
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel(t);
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TaskPage());
    }

    private async void RandomizerBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RandomizerPage());
    }
}

