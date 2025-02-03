using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public class UserManager : DatabaseManager
    {
        // Read users from the database
        public override DataTable Read()
        {
            DataTable table = new DataTable();
            string query = "SELECT user_id, name, email, role FROM Users";

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(table); // Fill the DataTable with user data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching users: " + ex.Message);
            }

            return table;
        }

        // Create a new user with a default password
        public override void Create(string name, string email, string role)
        {
            string query = "INSERT INTO Users (name, email, password, role) VALUES (@Name, @Email, SHA2('defaultpass', 256), @Role)";

            try
            {
                ExecuteQuery(query,
                    new MySqlParameter("@Name", name),
                    new MySqlParameter("@Email", email),
                    new MySqlParameter("@Role", role));

                MessageBox.Show("User Added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding the user: " + ex.Message);
            }
        }

        // Update existing user details
        public override void Update(int id, string name, string email, string role)
        {
            string query = "UPDATE Users SET name=@Name, email=@Email, role=@Role WHERE user_id=@UserID";

            try
            {
                ExecuteQuery(query,
                    new MySqlParameter("@UserID", id),
                    new MySqlParameter("@Name", name),
                    new MySqlParameter("@Email", email),
                    new MySqlParameter("@Role", role));

                MessageBox.Show("User Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating the user: " + ex.Message);
            }
        }

        // Delete a user
        public override void Delete(int id)
        {
            string query = "DELETE FROM Users WHERE user_id=@UserID";

            try
            {
                ExecuteQuery(query, new MySqlParameter("@UserID", id));
                MessageBox.Show("User Deleted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting the user: " + ex.Message);
            }
        }
    }
}
