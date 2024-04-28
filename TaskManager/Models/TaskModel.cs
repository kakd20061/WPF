using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class TaskModel(int id, string title, string description, Users? user)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
        public string Description { get; set; } = description;

        public Users? User { get; set; } = user;

        public TaskModel() : this(default, "", "", null)
        {
        }
    }
    
    public class TaskModelForDb(string title, string description)
    {
        public string Title { get; set; } = title;
        public string Description { get; set; } = description;

        public TaskModelForDb() : this("", "")
        {
        }
    }
}
