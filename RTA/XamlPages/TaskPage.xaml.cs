namespace RTA.XamlPages;

using Library.App.Models;
using RTA.ViewModels;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using Library.App.Services;

public partial class TaskPage : ContentPage
{
	public TaskViewModel _vm;
	public TaskPage(TaskViewModel vm)
	{
		InitializeComponent();
		_vm = vm;
		this.BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		_vm.GetTaskListCommand.Execute(null);
	}

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
		TaskItem task = (TaskItem)(sender as SwipeItem).BindingContext;
		_vm.SwipeDeleteItem(task);
    }
}
