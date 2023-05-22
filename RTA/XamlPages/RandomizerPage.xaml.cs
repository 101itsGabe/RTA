namespace RTA.XamlPages;
using RTA.ViewModels;

public partial class RandomizerPage : ContentPage
{
    public RandomizerPage()
    {
        InitializeComponent();
        BindingContext = new RandomizeViewModel();
    }


    public void RandomClick(object sender, EventArgs e)
    {
        (BindingContext as RandomizeViewModel).RandomizeTask();
    }
}