using Library.App.Services;
using RTA.ViewModels;
using CommunityToolkit.Maui.Views;
using Library.App.Models;

namespace RTA.XamlPages;

public partial class TaskPopup : Popup
{
    public TaskPopup(TaskPopupViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }

    

}