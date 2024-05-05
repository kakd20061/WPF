using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Shared
{
    public static class SharedData
    {
        public static ObservableCollection<Tasks> tasks { get; set; }
        public static ObservableCollection<Users> users { get; set; }
        public static ObservableCollection<TasksUsers> tasksUsers { get; set; }
    }
}
