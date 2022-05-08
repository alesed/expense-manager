using DAL.Models;
using System.Data.SqlClient;
using Dapper;

namespace DAL.Controllers
{
    public static class UserController
    {
        public static async Task<List<User>> GetAllUsers()
        {
            using (var db = new SqlConnection(Constants.Connection))
            {
                return (await db.QueryAsync<User>("SELECT * FROM Users")).ToList();
            }
        }

        public static async Task<List<User>> GetUser(int userId)
        {
            using (var db = new SqlConnection(Constants.Connection))
            {
                return (await db.QueryAsync<User>($"SELECT * FROM Users WHERE Id={userId}")).ToList();
            }
        }

        public static async Task CreateUser(string name, string surname)
        {
            using (var db = new SqlConnection(Constants.Connection))
            {
                await db.QueryAsync<User>($"INSERT INTO USERS(Name, Surname) VALUES (@name, @surname)", new User() { Name = name, Surname = surname});
            }
        }

        public static async Task<User> GetFirstUser()
        {
            var users = await GetAllUsers();
            return users.First();
        }
    }
}
