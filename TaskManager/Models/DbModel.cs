using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class taskManager : Database<taskManager>
    {
        public Table<Users> Users { get; set; }
        public Table<Tasks> Tasks { get; set; }
        public Table<TasksUsers> TasksUsers { get; set; }
    }
}
