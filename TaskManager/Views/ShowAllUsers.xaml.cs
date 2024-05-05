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
using TaskManager.ViewModels;

namespace BankApplication
{
    /// <summary>
    /// Logika interakcji dla klasy ShowAllUsers.xaml
    /// </summary>
    public partial class ShowAllUsers : Window
    {
        public ShowAllUsers()
        {
            InitializeComponent();
            ShowAllUsersViewModel viewModel = new();

            this.DataContext = viewModel;
        }
    }
}
