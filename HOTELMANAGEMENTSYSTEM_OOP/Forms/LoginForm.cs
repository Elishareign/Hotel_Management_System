using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using System;
using System.Windows.Forms;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;

namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService(new SQLiteUserRepository(DatabaseConfig.ConnectionString));
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Texts.Trim();
            string password = textBoxPassword.Texts.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                User user = _userService.Authenticate(email, password);
                if (user == null)
                {
                    MessageBox.Show("Invalid email or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoggedInUser = user;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to log in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally, log the exception for further analysis
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Any initialization logic can be added here if needed
        }
    }
}
