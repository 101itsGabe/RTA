using Library.App.Services;
using Library.App.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RTA.XamlPages;

namespace RTA.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
     
        public MainPageViewModel()
        {

            
        }

        [RelayCommand]
        public async void GoToTaskPage()
        {
            await AppShell.Current.GoToAsync(nameof(TaskPage));
        }
        
        [RelayCommand]
        public async void GoToRandomizerPage()
        {
            await AppShell.Current.GoToAsync(nameof(RandomizerPage));
        }
    }
}
