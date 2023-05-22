using Library.App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Library.App.Models;

namespace RTA.ViewModels
{
    public class RandomizeViewModel : INotifyPropertyChanged
    {
        public TaskService ts;
        public TaskItem curTask { get; set; }
        public string tsd;
        private static System.Timers.Timer aTimer;
        public string taskDescription
        {
            get { return curTask.taskDesc; }

        }

        public RandomizeViewModel()
        {
            ts = TaskService.Current;
            curTask = ts.Tasks[0];
        }
        public async void RandomizeTask()
        {
            Random rand = new Random();
            int t = rand.Next(8, 15);
            int countNum = 0;
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(0.3));
            while (await periodicTimer.WaitForNextTickAsync())
            {
                countNum++;
                setTask();
                if (countNum == t) { periodicTimer.Dispose(); }
            }
        }
        public void setTask()
        {
            Random rand = new Random();
            int t = rand.Next(0, ts.Tasks.Count);
            curTask = ts.Tasks[t];
            OnPropertyChanged(nameof(taskDescription));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
    }
}
