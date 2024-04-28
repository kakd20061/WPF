using BankApplication.Models;
using BankApplication.Services;

namespace BankApplication.Repositories;

public class TasksUsersRepository
{
    public void AddConnection(TasksUsersModel model)
    {
        using var db = new DbService().db;
        if(db.TasksUsers.All().Any(x => x.TaskId == model.TaskId))
        {
            db.TasksUsers.Delete(db.TasksUsers.All().First(x => x.TaskId == model.TaskId).Id);
        }
        db.TasksUsers.Insert(model);
    }

    public Users? GetUserByTaskId(int id)
    {
        using var db = new DbService().db;
        var userId = db.TasksUsers.All().FirstOrDefault(x => x.TaskId == id);
        if(userId == null)
        {
            return null;
        }
        var user = db.Users.Get(userId.UserId);
        return user;
    }
}