using BankApplication.Models;
using BankApplication.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Shared;

namespace BankApplication.Repositories
{
    public class TaskRepository
    {
        public void AddTask(TaskModel task)
        {
            using var db = new DbService().db;
            db.Tasks.Insert(new TaskModelForDb()
            {
                Title = task.Title,
                Description = task.Description
            });

            SharedData.tasks.Add(new Tasks()
            {
                Id= db.Tasks.All().Last().Id,
                Title = task.Title,
                Description = task.Description
            });
        }

        public void DeleteTask(int taskId)
        {
            using var db = new DbService().db;
            db.Tasks.Delete(taskId);
            if(db.TasksUsers.All().Any(x => x.TaskId == taskId))
            {
                db.TasksUsers.Delete(db.TasksUsers.All().First(x => x.TaskId == taskId).Id);
            }

            SharedData.tasks.Remove(SharedData.tasks.First(x => x.Id == taskId));
        }

        public ObservableCollection<Tasks> GetAllTasks()
        {
            using var db = new DbService().db;
            return new ObservableCollection<Tasks>(db.Tasks.All().ToList());
        }
    }
}
