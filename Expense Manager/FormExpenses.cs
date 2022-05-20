using DAL.Controllers;
using System.Data;

namespace Expense_Manager
{
    public partial class FormExpenses : Form
    {
        public FormExpenses()
        {
            InitializeComponent();
        }

        private async void FormExpenses_Load(object sender, EventArgs e)
        {
            await PopulateExpensesTable();
        }

        private async Task PopulateExpensesTable()
        {
            if (Globals.User == null) return;

            var userId = Globals.User.Id;
            var expenses = await PaymentController.GetAllExpensesByUser(userId);
            var expensesToShow = expenses
                                    .Select(item => new { Date = item.DateCreated, Amount = item.Amount })
                                    .OrderBy(item => item.Date)
                                    .ToList();
            expensesTable.DataSource = expensesToShow;
            expensesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void addExpenseButton_Click(object sender, EventArgs e)
        {
            var amountText = amountInput.Value;
            var amountToSend = Convert.ToDouble(amountText);
            var userId = Globals.User.Id;

            await PaymentController.InsertPaymentByUser(userId, amountToSend, false);
            await PopulateExpensesTable();
        }
    }
}
