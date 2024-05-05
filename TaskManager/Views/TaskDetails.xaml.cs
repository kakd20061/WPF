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
using TaskManager.ViewModels;

namespace BankApplication
{
    /// <summary>
    /// Logika interakcji dla klasy TaskDetails.xaml
    /// </summary>
    public partial class TaskDetails : Window
    {
        public TaskDetails(Tasks selectedTask)
        {
            InitializeComponent();

            TaskDetailsViewModel viewModel = new(selectedTask);
            this.DataContext = viewModel;
        }
    }
}
