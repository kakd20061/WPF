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
    class MainWindowViewModel
    {
        private readonly TaskRepository taskRepository = new();
        private readonly UserRepository userRepository = new();
        private readonly TasksUsersRepository tasksUsersRepository = new();

        public ObservableCollection<Tasks> Tasks { get; set; }

        public ICommand ShowAddUserWindowCommand { get; set; }
        public ICommand ShowAllUsersWindowCommand { get; set; }
        public ICommand ShowAddTaskWindowCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }
        public ICommand ShowTaskDetailsWindowCommand { get; set; }
        public object? selectedItem { get; set; }

        public MainWindowViewModel()
        {
            SharedData.tasks = taskRepository.GetAllTasks();
            SharedData.users = userRepository.GetUsers();
            SharedData.tasksUsers = tasksUsersRepository.GetConnections();


            Tasks = SharedData.tasks;

            ShowAddUserWindowCommand = new RelayCommand(ShowAddUserWindow, CanShowAddUserWindow);
            ShowAllUsersWindowCommand = new RelayCommand(ShowAllUsersWindow, CanShowAllUsersWindow);
            ShowAddTaskWindowCommand = new RelayCommand(ShowAddTaskWindow, CanShowAddTaskWindow);
            DeleteTaskCommand = new RelayCommand(DeleteTask, CanBeDeleted);
            ShowTaskDetailsWindowCommand = new RelayCommand(ShowTaskDetailsWindow, CanShowTaskDetailsWindow);
        }

        #region predicates

        private bool CanShowAddUserWindow(object obj)
        {
            return true;
        }

        private bool CanShowAllUsersWindow(object obj)
        {
            return true;
        }
        private bool CanShowAddTaskWindow(object obj)
        {
            return true;
        }
        private bool CanBeDeleted(object obj)
        {
            return true;
        }
        private bool CanShowTaskDetailsWindow(object obj)
        {
            return true;
        }

        #endregion

        #region actions

        private void ShowAddUserWindow(object obj)
        {
            var addUserWindow = new AddUser();
            addUserWindow.ShowDialog();
        }

        private void ShowAllUsersWindow(object obj)
        {
            var showAllUsersWindow = new ShowAllUsers();
            showAllUsersWindow.ShowDialog();
        }

        private void ShowAddTaskWindow(object obj)
        {
            var addTaskWindow = new AddTask();
            addTaskWindow.ShowDialog();
        }

        private void DeleteTask(object obj)
        {
            if (selectedItem == null) return;

            var task = selectedItem as Tasks;
            taskRepository.DeleteTask(task.Id);
            selectedItem = null;
        }

        private void ShowTaskDetailsWindow(object obj)
        {
            if (selectedItem == null) return;

            var task = selectedItem as Tasks;
            var taskDetailsWindow = new TaskDetails(task);
            taskDetailsWindow.ShowDialog();
        }

        #endregion
    }
}
