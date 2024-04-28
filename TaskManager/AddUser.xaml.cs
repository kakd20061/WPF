using BankApplication.Models;
using BankApplication.Repositories;
using BankApplication.Services;
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
    /// Logika interakcji dla klasy AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private UserModel User;
        private readonly UserRepository userRepository = new();
        public AddUser()
        {
            User = new();
            DataContext = User;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(User.Username != "" && User.Email != "" && User.FullName != "" && User.Address != "" && User.Phone != "")
            {
                userRepository.AddUser(User.Username, User.Email, User.FullName, User.Address, User.Phone);

                Close();
            }else
            {
                MessageBox.Show("Fill all fields");
            }
        }
    }
}
