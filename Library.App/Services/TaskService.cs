using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.App.Models;

namespace Library.App.Services
{
    public class TaskService
    {
        
    
        public List<TaskItem> Tasks;
        private static TaskService _instance;
        public TaskService()
        {
            Tasks = new List<TaskItem>();
            for (int i = 0; i <= 5; i++)
            {
                TaskItem t = new TaskItem();
                t.taskName += (i + 1).ToString();
                t.taskDesc += (i + 1).ToString();
                Tasks.Add(t);
            }
        }

        public static TaskService Current
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaskService();
                }
                return _instance;
            }
        }
    }
}

