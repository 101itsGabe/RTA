using Library.App.Services;
using Library.App.Models;


namespace RTA.ViewModels
{
    public class MainPageViewModel
    {
        public TaskItem MyTask { get; set; }
        public string taskDescription
        { get { return MyTask.taskDesc; } }

        public MainPageViewModel(TaskItem t)
        {
            MyTask = t;
        }
    }
}
