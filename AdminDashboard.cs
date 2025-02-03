using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public partial class AdminDashboard : Form
    {
        private Panel panelContent;
        private DataTable currentData;

        public AdminDashboard(string username)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {username} (Admin)";
            InitializePanelContent();
        }

        public AdminDashboard()
        {
            InitializeComponent();
            InitializePanelContent();
        }

        private void InitializePanelContent()
        {
            panelContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.panelAdminM.Controls.Add(panelContent);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, Admin!";
        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
            ShowUserData();
        }

        private void ManageCbtn_Click(object sender, EventArgs e)
        {
            ShowCourseData();
        }

        private void ManageEBtn_Click(object sender, EventArgs e)
        {
            ShowEnrollmentData();
        }

        private void SystemBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System settings functionality coming soon.");
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out...");
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void ShowUserData()
        {
            panelContent.Controls.Clear();

            currentData = new DataTable();
            currentData.Columns.Add("User ID");
            currentData.Columns.Add("Name");
            currentData.Columns.Add("Email");
            currentData.Columns.Add("Role");

            currentData.Rows.Add(1, "John Doe", "john@example.com", "Admin");
            currentData.Rows.Add(2, "Jane Smith", "jane@example.com", "Lecturer");
            currentData.Rows.Add(3, "Alice Johnson", "alice@example.com", "Student");
            currentData.Rows.Add(4, "Bob Brown", "bob@example.com", "Admin");

            DataGridView gridView = CreateEditableGridView(currentData);
            panelContent.Controls.Add(gridView);

            Button saveButton = new Button
            {
                Text = "Save Changes",
                Dock = DockStyle.Bottom
            };
            saveButton.Click += (sender, e) => SaveChanges(gridView);
            panelContent.Controls.Add(saveButton);
        }

        private void ShowCourseData()
        {
            panelContent.Controls.Clear();

            currentData = new DataTable();
            currentData.Columns.Add("Course ID");
            currentData.Columns.Add("Course Name");
            currentData.Columns.Add("Instructor");
            currentData.Columns.Add("Max Capacity");

            currentData.Rows.Add(101, "Mathematics", "Dr. Smith", 30);
            currentData.Rows.Add(102, "Science", "Dr. Johnson", 25);
            currentData.Rows.Add(103, "History", "Prof. Brown", 20);

            DataGridView gridView = CreateEditableGridView(currentData);
            panelContent.Controls.Add(gridView);

            Button saveButton = new Button
            {
                Text = "Save Changes",
                Dock = DockStyle.Bottom
            };
            saveButton.Click += (sender, e) => SaveChanges(gridView);
            panelContent.Controls.Add(saveButton);
        }

        private void ShowEnrollmentData()
        {
            panelContent.Controls.Clear();

            currentData = new DataTable();
            currentData.Columns.Add("Student ID");
            currentData.Columns.Add("Course ID");
            currentData.Columns.Add("Enrollment Date");

            currentData.Rows.Add(1, 101, "2023-09-01");
            currentData.Rows.Add(2, 102, "2023-09-01");
            currentData.Rows.Add(3, 103, "2023-09-01");

            DataGridView gridView = CreateEditableGridView(currentData);
            panelContent.Controls.Add(gridView);

            Button saveButton = new Button
            {
                Text = "Save Changes",
                Dock = DockStyle.Bottom
            };
            saveButton.Click += (sender, e) => SaveChanges(gridView);
            panelContent.Controls.Add(saveButton);
        }

        private DataGridView CreateEditableGridView(DataTable dataSource)
        {
            DataGridView gridView = new DataGridView
            {
                DataSource = dataSource,
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Blue },
                RowHeadersVisible = false,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(41, 128, 185),
                    ForeColor = Color.White,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                },
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(245, 245, 245)
                },
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = true,
                AllowUserToDeleteRows = true,
                ReadOnly = false
            };

            foreach (DataGridViewColumn column in gridView.Columns)
            {
                column.ReadOnly = false;
            }

            return gridView;
        }

        private void SaveChanges(DataGridView gridView)
        {
            MessageBox.Show("Changes have been saved successfully!");
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void panelAdminM_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
