using DAL.Controllers;
using System.Data;

namespace Expense_Manager
{
    public partial class FormIncomes : Form
    {
        public FormIncomes()
        {
            InitializeComponent();
        }

        private async void FormIncomes_Load(object sender, EventArgs e)
        {
            await PopulateIncomesTable();
        }

        private async Task PopulateIncomesTable()
        {
            if (Globals.User == null) return;

            var userId = Globals.User.Id;
            var incomes = await PaymentController.GetAllIncomesByUser(userId);
            var incomesToShow = incomes
                                    .Select(item => new { Date = item.DateCreated, Amount = item.Amount })
                                    .OrderBy(item => item.Date)
                                    .ToList();
            incomesTable.DataSource = incomesToShow;
            incomesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void addIncomeButton_Click(object sender, EventArgs e)
        {
            var amountText = amountInput.Text;
            var amountToSend = Convert.ToDouble(amountText);
            var userId = Globals.User.Id;

            await PaymentController.InsertPaymentByUser(userId, amountToSend, true);
            await PopulateIncomesTable();
        }
    }
}
