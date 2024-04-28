using BankApplication.Models;
using BankApplication.Repositories;
using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        private TaskModel Task;
        private readonly TaskRepository taskRepository = new();
        public AddTask()
        {
            Task = new();
            DataContext = Task;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Task.Description != "" && Task.Title != "")
            {
                taskRepository.AddTask(Task);

                Close();
            }
            else
            {
                MessageBox.Show("Title and description cannot be empty");
            }
        }
    }
}
