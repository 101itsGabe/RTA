using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.App.Models;
using System.Text.Json;
using System.IO;
using SQLite;

namespace Library.App.Services
{
    public class TaskService : ITaskItemService
    {

        private SQLiteAsyncConnection _dbConn;
        public TaskService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConn == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TaskItem.db3");
                _dbConn = new SQLiteAsyncConnection(dbPath);
                await _dbConn.CreateTableAsync<TaskItem>();
            }
        }
        public Task<int> AddTask(TaskItem taskitem)
        {
            return _dbConn.InsertAsync(taskitem);
        }

        public Task<int> DeleteTask(TaskItem taskitem)
        {
            return _dbConn.DeleteAsync(taskitem);
        }

        public Task<List<TaskItem>> GetTaskList()
        {
            var taskList = _dbConn.Table<TaskItem>().ToListAsync();
            return taskList;
        }

        public Task<int> UpdateTask(TaskItem taskitem)
        {
            return _dbConn.UpdateAsync(taskitem);
        }

        public Task<TaskItem> GetTaskById(int taskId)
        {
            var curTask = _dbConn.Table<TaskItem>().FirstOrDefaultAsync(t => t.Id == taskId);
            return curTask;
        }


    }
}

