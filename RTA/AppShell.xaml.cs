using RTA.XamlPages;

namespace RTA;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(TaskPage), typeof(TaskPage));
    }
}
