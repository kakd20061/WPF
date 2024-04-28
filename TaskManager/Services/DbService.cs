using BankApplication.Models;
using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Services
{
    public class DbService
    {
        public taskManager db { get; set; }
        public DbService()
        {
            var connectionString = "Data Source=taskManager.db";

            var connection = new SqliteConnection(connectionString);

            db = taskManager.Init((DbConnection)connection, commandTimeout: 2);
        }
    }
}
