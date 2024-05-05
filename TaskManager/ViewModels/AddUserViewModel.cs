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
    class AddUserViewModel
    {
        private readonly UserRepository userRepository = new();

        public UserModel user { get; set; }

        public ICommand AddUserCommand { get; set; }

        public AddUserViewModel()
        {
            user = new();
            AddUserCommand = new RelayCommand(AddUser, CanBeAdded);
        }
        #region predicates
        private bool CanBeAdded(object obj)
        {
            return true;
        }
        #endregion

        #region actions

        private void AddUser(object obj)
        {
            if (user.Username != "" && user.Email != "" && user.FullName != "" && user.Address != "" && user.Phone != "")
            {
                userRepository.AddUser(new UserModel(user.Username, user.Email, user.FullName, user.Address, user.Phone));

                MessageBox.Show("User added successfully");
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        #endregion
    }
}