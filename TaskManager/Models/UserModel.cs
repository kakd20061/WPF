using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class UserModel(string username, string email, string fullName, string address, string phone)
    {
        public string Username { get; set; } = username;
        public string Email { get; set; } = email;
        public string FullName { get; set; } = fullName;
        public string Address { get; set; } = address;
        public string Phone { get; set; } = phone;

        public UserModel() : this("", "", "", "", "")
        {
        }
    }
}
