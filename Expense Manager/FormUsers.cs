using DAL.Controllers;
using DAL.Models;

namespace Expense_Manager
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            var name = userNameInput.Text;
            var surname = userSurnameInput.Text;

            if (!ValidateUser(name, surname))
            {
                MessageBox.Show("Please, fill both name and surname!");
                return;
            }

            await UserController.CreateUser(name, surname);

            MessageBox.Show("User created!");

            await PopulateUsersDropdown();

            userNameInput.Text = "";
            userSurnameInput.Text = "";
        }

        private bool ValidateUser(string name, string surname)
        {
            if (name == null || 
                name.Length == 0 ||
                surname == null || 
                surname.Length == 0)
            {
                return false;
            }
            return true;
        }

        private async void FormUsers_Load(object sender, EventArgs e)
        {
            await PopulateUsersDropdown();
        }

        private async Task PopulateUsersDropdown()
        {
            var users = await UserController.GetAllUsers();
            users = users.Where(item => item.Id != Globals.User.Id).ToList();

            var result = new List<User>();
            result.Add(Globals.User);
            result.AddRange(users);

            usersDropdown.ValueMember = "Id";
            usersDropdown.DisplayMember = "Name";
            usersDropdown.DataSource = result;
        }

        private void usersDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentUser = (User)usersDropdown.SelectedItem;
            Globals.User = new User() { Id = currentUser.Id, Name = currentUser.Name, Surname = currentUser.Surname };
            FormLayout.sidebarUserLabel.Text = $"{currentUser.Name} {currentUser.Surname}";
        }
    }
}
