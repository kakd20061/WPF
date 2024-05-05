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
    class AddTaskViewModel
    {
        private readonly TaskRepository taskRepository = new();

        public TaskModel task { get; set; }

        public ICommand AddTaskCommand { get; set; }

        public AddTaskViewModel()
        {

            task = new();
            AddTaskCommand = new RelayCommand(AddTask, CanBeAdded);
        }
        #region predicates
        private bool CanBeAdded(object obj)
        {
            return true;
        }
        #endregion

        #region actions

        private void AddTask(object obj)
        {
            if (task.Description != "" && task.Title != "")
            {
                taskRepository.AddTask(task);

                MessageBox.Show("Task added successfully");

            }
            else
            {
                MessageBox.Show("Title and description cannot be empty");
            }
        }

        #endregion
    }
}