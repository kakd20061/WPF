using BankApplication.Models;
using BankApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Repositories
{
    public class UserRepository
    {
        public void AddUser(string username, string email, string fullName, string address, string phone)
        {
            using var db = new DbService().db;
            db.Users.Insert(new UserModel(username, email, fullName, address, phone));
        }

        public void DeleteUser(int id)
        {
            using var db = new DbService().db;
            db.Users.Delete(id);
            if(db.TasksUsers.All().Any(x => x.UserId == id))
            {
                foreach (var connection in db.TasksUsers.All().Where(x=>x.UserId == id))
                {
                    db.TasksUsers.Delete(connection.Id);
                }
            }
        }

        public Users GetUser(int id)
        {
            using var db = new DbService().db;
            return db.Users.Get(id);
        }

        public List<Users> GetUsers()
        {
            using var db = new DbService().db;
            return db.Users.All().ToList();
        }
    }
}
