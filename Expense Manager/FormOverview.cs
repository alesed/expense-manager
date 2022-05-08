using DAL.Controllers;

namespace Expense_Manager
{
    public partial class FormOverview : Form
    {
        public FormOverview()
        {
            InitializeComponent();
            LoadOverview();
        }

        public static async void LoadOverview()
        {
            if (Globals.User == null) return;

            var userId = Globals.User.Id;
            var payments = await PaymentController.GetAllPaymentsByUser(userId);
            var incomes = await PaymentController.GetAllIncomesByUser(userId);
            var expenses = await PaymentController.GetAllExpensesByUser(userId);

            var currentBalance = payments.Aggregate(0.0, (current, next) => current += next.IsIncome ? next.Amount : next.Amount * -1);
            var lastIncomePayments = incomes.OrderByDescending(income => income.Id);
            var lastExpensePayments = expenses.OrderByDescending(expense => expense.Id);

            balance.Text = $"{currentBalance} USD";
            lastIncome.Text = lastIncomePayments.Count() > 0 ? $"+{lastIncomePayments.First().Amount} USD" : "Nothing yet...";
            lastExpense.Text = lastExpensePayments.Count() > 0 ? $"-{lastExpensePayments.First().Amount} USD" : "Nothing yet...";
            incomingsCounter.Text = lastIncomePayments.Count().ToString();
            outcomingsCounter.Text = lastExpensePayments.Count().ToString();
        }
    }
}
