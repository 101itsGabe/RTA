namespace RTA.XamlPages;
using RTA.ViewModels;

public partial class RandomizerPage : ContentPage
{
    public RandomizerPage(RandomizeViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }



}