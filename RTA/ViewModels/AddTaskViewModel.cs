using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Library.App.Services;
using Library.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTA.XamlPages;

namespace RTA.ViewModels
{
    public partial class AddTaskViewModel : ObservableObject
    {
        private readonly ITaskItemService _taskService;

        public AddTaskViewModel(ITaskItemService itis)
        {
            _taskService = itis;
        }

        [ObservableProperty]
        private string _taskDesc;

        [RelayCommand]
        public async void AddUpdateTask()
        {
            var response = _taskService.AddTask(new TaskItem 
            { 
                TaskDesc = TaskDesc 
            });

            if (response.Result > 0)
                await Shell.Current.DisplayAlert("TaskItem Added!", "Task Added To List!", "OK");
            else
                await Shell.Current.DisplayAlert("Task Not Added!", "Task Not Added To List!", "OK");
            
            
        }
    }
}
