using BankApplication;
using BankApplication.Models;
using BankApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TaskManager.Commands;
using TaskManager.Shared;

namespace TaskManager.ViewModels
{
    class TaskDetailsViewModel
    {
        private readonly UserRepository userRepository = new();
        private readonly TasksUsersRepository userTaskRepository = new();

        public Tasks task { get; set; }
        public ObservableCollection<string> usernames { get; set; }
        public string? selectedUsername { get; set; }
        public ICommand AssignUserCommand { get; set; }

        public TaskDetailsViewModel(Tasks selectedTask)
        {
            task = selectedTask;
            usernames = new(SharedData.users.Select(n=>n.Username));
            selectedUsername = userTaskRepository.GetUserByTaskId(selectedTask.Id).Username;
            AssignUserCommand = new RelayCommand(AssignUser, CanAssignUser);
        }
        #region predicates

        private bool CanAssignUser(object obj)
        {
            return true;
        }

        #endregion

        #region actions
        private void AssignUser(object obj)
        {
            if (selectedUsername == null)
            {
                MessageBox.Show("Select user first");
            }
            else
            {
                var user = userRepository.GetUsers().First(n => n.Username == selectedUsername);
                var taskUser = new TasksUsersModel()
                {
                    TaskId = task.Id,
                    UserId = user.Id
                };
                userTaskRepository.AddConnection(taskUser);
                MessageBox.Show("User added to task");
            }
        }
        #endregion
    }
}