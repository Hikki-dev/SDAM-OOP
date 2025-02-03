using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public class CourseManager : DatabaseManager
    {
        public override DataTable Read()
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT course_id, course_name, instructor_id, max_capacity FROM Courses";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public override void Create(string name, string instructorID, string maxCapacity)
        {
            string query = "INSERT INTO Courses (course_name, instructor_id, max_capacity) VALUES (@Name, @InstructorID, @MaxCapacity)";
            ExecuteQuery(query,
                new MySqlParameter("@Name", name),
                new MySqlParameter("@InstructorID", instructorID),
                new MySqlParameter("@MaxCapacity", maxCapacity));
            MessageBox.Show("Course Added Successfully!");
        }

        public override void Update(int id, string name, string instructorID, string maxCapacity)
        {
            string query = "UPDATE Courses SET course_name=@Name, instructor_id=@InstructorID, max_capacity=@MaxCapacity WHERE course_id=@CourseID";
            ExecuteQuery(query,
                new MySqlParameter("@CourseID", id),
                new MySqlParameter("@Name", name),
                new MySqlParameter("@InstructorID", instructorID),
                new MySqlParameter("@MaxCapacity", maxCapacity));
            MessageBox.Show("Course Updated Successfully!");
        }

        public override void Delete(int id)
        {
            string query = "DELETE FROM Courses WHERE course_id=@CourseID";
            ExecuteQuery(query, new MySqlParameter("@CourseID", id));
            MessageBox.Show("Course Deleted Successfully!");
        }
    }
}
