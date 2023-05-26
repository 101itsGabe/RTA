using Library.App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.App.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using RTA.XamlPages;

namespace RTA.ViewModels
{
    public partial class TaskViewModel : ObservableObject
    {
        public ObservableCollection<TaskItem> Tasks { get; set; } = new ObservableCollection<TaskItem>();
        ITaskItemService _taskitemService;

        public TaskViewModel(ITaskItemService taskService)
        {
            _taskitemService = taskService;
        }

        [RelayCommand]
        public async void GetTaskList()
        {
            var taskList = await _taskitemService.GetTaskList();
            if (taskList?.Count > 0)
            {
                Tasks.Clear();
                foreach (var task in taskList)
                {
                    Tasks.Add(task);
                }
            }
        }

        [RelayCommand]
        public async void ShowAddTask()
        {
            await AppShell.Current.GoToAsync(nameof(AddTaskPage));
        }

    }
}
