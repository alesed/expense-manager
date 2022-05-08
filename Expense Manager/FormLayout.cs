using DAL.Controllers;
using DAL.Models;
using System.Runtime.InteropServices;

namespace Expense_Manager
{
    public partial class FormLayout : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public FormLayout()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnOverview.Height;
            pnlNav.Top = btnOverview.Top;
            pnlNav.Left = btnOverview.Left;

            lbltitle.Text = "Overview";
            FormOverview frmDashboard_vrb = new FormOverview() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var currentUser = await UserController.GetFirstUser();
            Globals.User = new User() { Id = currentUser.Id, Name = currentUser.Name, Surname = currentUser.Surname };
            sidebarUserLabel.Text = $"{currentUser.Name} {currentUser.Surname}";
            FormOverview.LoadOverview();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOverview.Height;
            pnlNav.Top = btnOverview.Top;
            pnlNav.Left = btnOverview.Left;
            btnOverview.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Overview";
            this.pnlFormLoader.Controls.Clear();
            FormOverview frmDashboard_vrb = new FormOverview() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

        }

        private void btnIncomes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnIncomes.Height;
            pnlNav.Top = btnIncomes.Top;
            btnIncomes.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Incomes";
            this.pnlFormLoader.Controls.Clear();
            FormIncomes frmIncomes_vrb = new FormIncomes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmIncomes_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmIncomes_vrb);
            frmIncomes_vrb.Show();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExpenses.Height;
            pnlNav.Top = btnExpenses.Top;
            btnExpenses.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            FormExpenses frmExpenses_vrb = new FormExpenses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmExpenses_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmExpenses_vrb);
            frmExpenses_vrb.Show();
            lbltitle.Text = "Expenses";
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUsers.Height;
            pnlNav.Top = btnUsers.Top;
            btnUsers.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            FormUsers frmSettings_vrb = new FormUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSettings_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmSettings_vrb);
            frmSettings_vrb.Show();
            lbltitle.Text = "Users";
        }

        private void btnOverview_Leave(object sender, EventArgs e)
        {
            btnOverview.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnIncomes_Leave(object sender, EventArgs e)
        {
            btnIncomes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExpenses_Leave(object sender, EventArgs e)
        {
            btnExpenses.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUsers_Leave(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }
    }
}
