using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.App.Models
{
    public class TaskItem
    {
        public string taskDesc;
        public string taskName { get; set; }
        public TaskItem()
        {
            taskDesc = "Task ";
            taskName = "Task";
        }
        public TaskItem(string desc)
        {
            taskDesc = desc;
            taskName = "Task";
        }
        public override string ToString()
        {
            return $"{taskDesc}";
        }
    }
}
