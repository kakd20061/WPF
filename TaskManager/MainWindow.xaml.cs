using BankApplication.Models;
using BankApplication.Repositories;
using GalaSoft.MvvmLight.Command;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TaskRepository taskRepository = new();
        private readonly TasksUsersRepository tasksUsersRepository = new();

        public MainWindow()
        {
            InitializeComponent();
            var testArray = taskRepository.GetAllTasks();
            var readyTasks = testArray.Select(n => new TaskModel(n.Id,n.Title, n.Description, tasksUsersRepository.GetUserByTaskId(n.Id))).ToList();
            
            tasks.ItemsSource = readyTasks;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var addUserWindow = new AddUser();
            addUserWindow.ShowDialog();
        }

        private void ShowUsers_Click(object sender, RoutedEventArgs e)
        {
            var addUserWindow = new ShowAllUsers();
            addUserWindow.ShowDialog();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            var addTaskWindow = new AddTask();
            addTaskWindow.ShowDialog();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            var testArray = taskRepository.GetAllTasks();
            var readyTasks = testArray.Select(n => new TaskModel(n.Id,n.Title, n.Description, tasksUsersRepository.GetUserByTaskId(n.Id))).ToList();
            
            tasks.ItemsSource = readyTasks;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (tasks.SelectedItem == null) return;
            
            var before = tasks.SelectedItem as TaskModel;
            var after = new Tasks()
            {
                Id = before.Id,
                Title = before.Title,
                Description = before.Description
            };
            taskRepository.DeleteTask(after.Id);
            var testArray = taskRepository.GetAllTasks();
            var readyTasks = testArray.Select(n => new TaskModel(n.Id,n.Title, n.Description, tasksUsersRepository.GetUserByTaskId(n.Id))).ToList();
                
            tasks.ItemsSource = readyTasks;
            tasks.SelectedItem = null;
        }
        

        private void Tasks_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tasks.SelectedItem == null) return;
            
            var before = tasks.SelectedItem as TaskModel;
            var taskDetailsWindow = new TaskDetails(new Tasks()
            {
                Id = before.Id,
                Title = before.Title,
                Description = before.Description
            });
            taskDetailsWindow.ShowDialog();
        }
    }
}