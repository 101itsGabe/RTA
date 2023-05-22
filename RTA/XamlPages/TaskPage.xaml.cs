namespace RTA.XamlPages;

using Library.App.Models;
using RTA.ViewModels;
using CommunityToolkit.Maui.Views;

public partial class TaskPage : ContentPage
{
	public TaskItem t;
	public TaskPage()
	{
		InitializeComponent();
		BindingContext = new TaskViewModel();
	}

    private async void AddTask(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new TaskPopup());
        (BindingContext as TaskViewModel).UpdateList();
    }

}