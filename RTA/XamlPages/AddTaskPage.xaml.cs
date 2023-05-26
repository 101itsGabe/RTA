using RTA.ViewModels;

namespace RTA.XamlPages;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage(AddTaskViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}