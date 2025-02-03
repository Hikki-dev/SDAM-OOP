using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Course_Managment_APP.Models
{
    public class Admin : User
    {
        public Admin(string email) : base(email) { }

        public override void Login(string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_id, name FROM Users WHERE email=@Email AND password=HASHBYTES('SHA2_256', @Password) AND role='Admin'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        UserID = Convert.ToInt32(reader["user_id"]);
                        Name = reader["name"].ToString();

                        MessageBox.Show($"Welcome, {Name} (Admin)");
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials.");
                    }
                }
            }
        }
    }
}
