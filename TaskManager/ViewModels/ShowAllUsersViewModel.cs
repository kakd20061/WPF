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
    class ShowAllUsersViewModel
    {
        private readonly UserRepository userRepository = new();

        public ObservableCollection<Users> Users { get; set; }

        public ICommand DeleteUserCommand { get; set; }
        public object? selectedItem { get; set; }

        public ShowAllUsersViewModel()
        {

            Users = SharedData.users;

            DeleteUserCommand = new RelayCommand(DeleteUser, CanBeDeleted);
        }
        #region predicates
        private bool CanBeDeleted(object obj)
        {
            return true;
        }
        #endregion

        #region actions
        private void DeleteUser(object obj)
        {
            if (selectedItem == null) return;

            var user = selectedItem as Users;
            userRepository.DeleteUser(user.Id);
            selectedItem = null;
        }
        #endregion
    }
}