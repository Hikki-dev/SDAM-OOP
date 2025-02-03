using System;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public abstract class DashboardBase : Form
    {
        public string UserName { get; set; }
        public string Role { get; set; }

        // Constructor
        protected DashboardBase(string userName, string role)
        {
            UserName = userName;
            Role = role;
        }

        // Abstract methods for child classes to define specific functionality
        public abstract void InitializeDashboard();
        public abstract void ManageTasks();
        public abstract void ManageCourses();
        public abstract void ManageStudents();
        public abstract void LogOut();
    }
}
