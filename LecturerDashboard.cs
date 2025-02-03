using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public partial class LecturerDashboard : Form
    {
        private Panel panelContent;

        public LecturerDashboard(string userName)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {userName} (Lecturer)";
            InitializePanelContent();
        }

        private void InitializePanelContent()
        {
            panelContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.PanelLecture.Controls.Add(panelContent);
        }

        private void LecturerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, Lecturer!";
        }

        private void MngTaskBtn_Click(object sender, EventArgs e)
        {
            ShowTaskData();
        }

        private void MngCourseBtn_Click(object sender, EventArgs e)
        {
            ShowCourseData();
        }

        private void ViewStndsBtn_Click(object sender, EventArgs e)
        {
            ShowStudentData();
        }

        private void lLogBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out...");
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void ShowTaskData()
        {
            panelContent.Controls.Clear();

            DataTable tasks = new DataTable();
            tasks.Columns.Add("Task ID");
            tasks.Columns.Add("Task Name");
            tasks.Columns.Add("Due Date");

            tasks.Rows.Add(1, "Assignment 1", "2023-09-30");
            tasks.Rows.Add(2, "Midterm Exam", "2023-10-15");
            tasks.Rows.Add(3, "Final Exam", "2023-12-10");

            DataGridView gridView = new DataGridView
            {
                DataSource = tasks,
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
                BorderStyle = BorderStyle.None
            };

            panelContent.Controls.Add(gridView);
        }

        private void ShowCourseData()
        {
            panelContent.Controls.Clear();

            DataTable courses = new DataTable();
            courses.Columns.Add("Course ID");
            courses.Columns.Add("Course Name");
            courses.Columns.Add("Instructor");
            courses.Columns.Add("Max Capacity");

            courses.Rows.Add(101, "Mathematics", "Dr. Smith", 30);
            courses.Rows.Add(102, "Science", "Dr. Johnson", 25);
            courses.Rows.Add(103, "History", "Prof. Brown", 20);

            DataGridView gridView = new DataGridView
            {
                DataSource = courses,
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
                BorderStyle = BorderStyle.None
            };

            panelContent.Controls.Add(gridView);
        }

        private void ShowStudentData()
        {
            panelContent.Controls.Clear();

            DataTable students = new DataTable();
            students.Columns.Add("Student ID");
            students.Columns.Add("Name");
            students.Columns.Add("Email");

            students.Rows.Add(1, "John Doe", "johndoe@example.com");
            students.Rows.Add(2, "Jane Smith", "janesmith@example.com");
            students.Rows.Add(3, "Alice Johnson", "alicejohnson@example.com");

            DataGridView gridView = new DataGridView
            {
                DataSource = students,
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
                BorderStyle = BorderStyle.None
            };

            panelContent.Controls.Add(gridView);
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void panelAdminM_Paint(object sender, PaintEventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e) { }
    }
}
