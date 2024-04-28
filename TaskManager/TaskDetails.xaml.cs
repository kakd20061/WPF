using BankApplication.Models;
using BankApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankApplication
{
    /// <summary>
    /// Logika interakcji dla klasy TaskDetails.xaml
    /// </summary>
    public partial class TaskDetails : Window
    {
        private readonly UserRepository userRepository = new();
        private readonly TasksUsersRepository userTaskRepository = new();
        public TaskDetails(Tasks selectedTask)
        {
            InitializeComponent();

            title.DataContext = selectedTask;
            desc.DataContext = selectedTask;
            users.ItemsSource = userRepository.GetUsers().Select(n=>n.Username);
            var usersSelectedItem = userTaskRepository.GetUserByTaskId(selectedTask.Id);
            if (usersSelectedItem != null)
            {
                users.SelectedItem = usersSelectedItem.Username;
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if(users.SelectedItem == null)
            {
                MessageBox.Show("Select user first");
            }
            else
            {
                var user = userRepository.GetUsers().First(n => n.Username == users.SelectedItem.ToString());
                var taskUser = new TasksUsersModel()
                {
                    TaskId = ((Tasks)title.DataContext).Id,
                    UserId = user.Id
                };
                userTaskRepository.AddConnection(taskUser);
                MessageBox.Show("User added to task");
                Close();
            }
        }
    }
}
