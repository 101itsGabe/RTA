using Library.App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Library.App.Models;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RTA.ViewModels
{
    public partial class RandomizeViewModel : ObservableObject
    {
        
        private static System.Timers.Timer aTimer;

        public ObservableCollection<TaskItem> Tasks { get; set; } = new ObservableCollection<TaskItem>();
        ITaskItemService _taskitemService;

        [ObservableProperty]
        private string _taskDesc;



        public RandomizeViewModel(ITaskItemService taskService)
        {
            _taskitemService = taskService;
            _taskDesc = "Click Me!";
        }

        
        [RelayCommand]
        public async void RandomizeTask()
        {
            SetTimer();
            Random rand = new Random();
            int t = rand.Next(8,15);
            int countNum = 0;
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(0.3));
            while (await periodicTimer.WaitForNextTickAsync())
            {
                countNum++;
                UpdateTaskString();
                if (countNum == t) { periodicTimer.Dispose(); }
            }
        }
        public async void UpdateTaskString()
        {
            Random random = new Random();
            var taskList = await _taskitemService.GetTaskList();
            int t = random.Next(0, taskList.Count);
            
            var curTask = taskList[t];
            if (curTask != null)
            {
                    TaskDesc = curTask.TaskDesc;
                    OnTaskDescChanged(nameof(TaskDesc));
            }
            
        }


        public void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {

        }

        partial void OnTaskDescChanged(string oldValue, string newValue)
        {
            
        }
       

    }
}
