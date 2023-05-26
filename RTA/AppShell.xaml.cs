using RTA.XamlPages;

namespace RTA;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(TaskPage), typeof(TaskPage));
		Routing.RegisterRoute(nameof(AddTaskPage), typeof(AddTaskPage));
		Routing.RegisterRoute(nameof(RandomizerPage), typeof(RandomizerPage));
    }
}
