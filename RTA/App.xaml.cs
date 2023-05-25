using Library.App.Models;
using RTA.XamlPages;

namespace RTA;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

    }
}
