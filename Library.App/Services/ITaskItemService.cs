using Library.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.App.Services
{
    public interface ITaskItemService
    {
        Task<List<TaskItem>> GetTaskList();

        Task<int> AddTask(TaskItem taskitem);
        Task<int> DeleteTask(TaskItem taskitem);
        Task<int> UpdateTask(TaskItem taskitem);

        Task<TaskItem> GetTaskById(int taskId);
    }
}
