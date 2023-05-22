using Library.App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.KotlinX.Coroutines.Scheduling;
using Library.App.Models;

namespace RTA.ViewModels
{
    public class TaskViewModel
    {
        public TaskService taskService { get; set; }
        public TaskItem curTask { get; set; }
        public int TasksperHeight { get; set; }
        public List<TaskItem> tasksList;
        public ObservableCollection<TaskItem> tasks;

        public TaskViewModel()
        {
            taskService = TaskService.Current;
            tasks = new ObservableCollection<TaskItem>(taskService.Tasks);
        }

        public ObservableCollection<TaskItem> ListOfTasks
        {
            get
            {
                return tasks;
            }

        }

        public void UpdateList()
        {
            for (int i = tasks.Count - 1; i < taskService.Tasks.Count; i++)
            {
                tasks.Add(taskService.Tasks[i]);
            }
            OnPropertyChanged(nameof(ListOfTasks));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
