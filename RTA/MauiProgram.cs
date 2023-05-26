using CommunityToolkit.Maui;
using Library.App.Models;
using Microsoft.Extensions.Logging;
using Library.App.Services;
using RTA.XamlPages;
using RTA.ViewModels;

namespace RTA;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        //Services
        builder.Services.AddSingleton<ITaskItemService, TaskService>();

        //View Registration
        builder.Services.AddSingleton<TaskPage>();
        builder.Services.AddTransient<AddTaskPage>();
        builder.Services.AddTransient<RandomizerPage>();

        //ViewModels
        builder.Services.AddSingleton<TaskViewModel>();
        builder.Services.AddTransient<AddTaskViewModel>();
        builder.Services.AddTransient<RandomizeViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
