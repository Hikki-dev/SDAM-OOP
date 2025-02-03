using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public class DatabaseConnection
    {
        private string connectionString = "Server=localhost;Database=coursedatabase;User ID=Nethan;Password=1234;SslMode=none;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public bool CheckLogin(string username, string password, out string role)
        {
            role = null;
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM Users WHERE username=@Username AND password=@Password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        cmd.Parameters.AddWithValue("@Password", password.Trim());

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            role = result.ToString();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("❌ Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
            return false;
        }

        public bool AddUser(string name, string username, string password, string role)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (name, username, password, role) VALUES (@Name, @Username, @Password, @Role)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ User added successfully!");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
            return false;
        }
    }
}
