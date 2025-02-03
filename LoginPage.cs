using System;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public partial class LoginPage : Form
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (dbConnection.CheckLogin(username, password, out string role))
            {
                MessageBox.Show($"Welcome, {role}!");

                if (role == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard(username);
                    adminDashboard.Show();
                }
                else if (role == "Lecturer")
                {
                    LecturerDashboard lecturerDashboard = new LecturerDashboard(username);
                    lecturerDashboard.Show();
                }
                else if (role == "Student")
                {
                    StudentDashboard studentDashboard = new StudentDashboard(username);
                    studentDashboard.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
