using BankApplication.Models;
using BankApplication.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Shared;

namespace BankApplication.Repositories
{
    public class UserRepository
    {
        public void AddUser(UserModel model)
        {
            using var db = new DbService().db;
            db.Users.Insert(model);

            SharedData.users.Add(new Users()
            {
                Id = db.Users.All().Last().Id,
                Username = model.Username,
                Email = model.Email,
                FullName = model.FullName,
                Address = model.Address,
                Phone = model.Phone
            });
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
            SharedData.users.Remove(SharedData.users.First(x => x.Id == id));
        }

        public Users GetUser(int id)
        {
            using var db = new DbService().db;
            return db.Users.Get(id);
        }

        public ObservableCollection<Users> GetUsers()
        {
            using var db = new DbService().db;
            return new ObservableCollection<Users>(db.Users.All().ToList());
        }
    }
}
