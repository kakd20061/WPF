namespace BankApplication.Models;

public class TasksUsersModel(int uid, int tid)
{
    public int UserId { get; set; } = uid;
    public int TaskId { get; set; } = tid;

    public TasksUsersModel() : this(0, 0)
    {
    }
}