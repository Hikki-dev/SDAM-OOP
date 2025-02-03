using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public partial class StudentDashboard : Form
    {
        private string userName;
        private Panel panelContent;

        public StudentDashboard(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            lblWelcome.Text = $"Welcome, {userName} (Student)";
            InitializePanelContent();
        }

        private void InitializePanelContent()
        {
            panelContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.PanelStudent.Controls.Add(panelContent);
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {userName} (Student)!";
        }

        private void ViewCrsBtn_Click(object sender, EventArgs e)
        {
            ShowCourseData();
        }

        private void EnrolledBtn_Click(object sender, EventArgs e)
        {
            ShowEnrolledCourseData();
        }

        private void GradesBtn_Click(object sender, EventArgs e)
        {
            ShowGradesData();
        }

        private void sLogBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out...");
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
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

            DisplayDataInGrid(courses);
        }

        private void ShowEnrolledCourseData()
        {
            panelContent.Controls.Clear();

            DataTable enrolledCourses = new DataTable();
            enrolledCourses.Columns.Add("Course ID");
            enrolledCourses.Columns.Add("Course Name");
            enrolledCourses.Columns.Add("Instructor");
            enrolledCourses.Columns.Add("Enrollment Date");

            enrolledCourses.Rows.Add(101, "Mathematics", "Dr. Smith", "2023-09-01");
            enrolledCourses.Rows.Add(102, "Science", "Dr. Johnson", "2023-09-01");

            DisplayDataInGrid(enrolledCourses);
        }

        private void ShowGradesData()
        {
            panelContent.Controls.Clear();

            DataTable grades = new DataTable();
            grades.Columns.Add("Course ID");
            grades.Columns.Add("Course Name");
            grades.Columns.Add("Grade");

            grades.Rows.Add(101, "Mathematics", "A");
            grades.Rows.Add(102, "Science", "B");
            grades.Rows.Add(103, "History", "A");

            DisplayDataInGrid(grades);
        }

        private void DisplayDataInGrid(DataTable data)
        {
            DataGridView gridView = new DataGridView
            {
                DataSource = data,
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

        private void lblWelcome_Click(object sender, EventArgs e) { }
    }
}
