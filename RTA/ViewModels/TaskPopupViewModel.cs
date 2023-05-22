using Library.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.KotlinX.Coroutines.Scheduling;

namespace RTA.ViewModels
{
    public class TaskPopupViewModel
    {
        public TaskItem curTask { get; set; }
        public string TaskDescription { get; set; }
        public TaskViewModel t;
        public TaskPopupViewModel()
        {
            curTask = new TaskItem();
        }
    }
}
