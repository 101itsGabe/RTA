using Library.App.Models;
using Library.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Reflection;

namespace RTA.ViewModels
{
    public partial class TaskPopupViewModel : ObservableObject
    {
        public readonly ITaskItemService _taskitemService;
        public TaskViewModel t;
        public TaskPopupViewModel(ITaskItemService tis)
        {
            _taskitemService = tis;
        }
        [ObservableProperty]
        private string _taskDesc;


        [RelayCommand]
        public void AddUpdateTask()
        {
             _taskitemService.AddTask(new TaskItem
            {
                TaskDesc = TaskDesc
            });

        }
    }
}
