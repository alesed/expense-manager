using DAL.Models;
using System.Data.SqlClient;
using Dapper;

namespace DAL.Controllers
{
    public static class PaymentController
    {
        public static async Task<List<Payment>> GetAllPaymentsByUser(int userId)
        {
            using (var db = new SqlConnection(Constants.Connection))
            {
                return (await db.QueryAsync<Payment>($"SELECT * FROM Payments WHERE UserId={userId}")).ToList();
            }
        }

        public static async Task<List<Payment>> GetAllIncomesByUser(int userId)
        {
            using (var db = new SqlConnection(Constants.Connection))
            {
                return (await db.QueryAsync<Payment>($"SELECT * FROM Payments WHERE UserId={userId} AND IsIncome=1")).ToList();
            }
        }

        public static async Task<List<Payment>> GetAllExpensesByUser(int userId)
        {
            using (var db = new SqlConnection(Constants.Connection))
            {
                return (await db.QueryAsync<Payment>($"SELECT * FROM Payments WHERE UserId={userId} AND IsIncome=0")).ToList();
            }
        }

        public static async Task InsertPaymentByUser(int userId, double amount, bool isIncome)
        {
            using (var db = new SqlConnection(Constants.Connection))
            {
                await db.QueryAsync<Payment>(
                        $"INSERT INTO PAYMENTS(IsIncome, DateCreated, Amount, UserId) VALUES (@isincome, @datecreated, @amount, @userid)", 
                        new Payment() { IsIncome = isIncome, DateCreated = DateTime.Today, Amount = amount, UserId = userId }
                    );
            }
        }
    }
}
