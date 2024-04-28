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
    /// Logika interakcji dla klasy ShowAllUsers.xaml
    /// </summary>
    public partial class ShowAllUsers : Window
    {
        private readonly UserRepository userRepository = new();

        public ShowAllUsers()
        {
            InitializeComponent();
            users.ItemsSource = userRepository.GetUsers();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (users.SelectedItem == null) return;
            
            userRepository.DeleteUser((users.SelectedItem as Users).Id);
            users.ItemsSource = userRepository.GetUsers();
        }
    }
}
