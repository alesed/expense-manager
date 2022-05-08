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
    }
}
