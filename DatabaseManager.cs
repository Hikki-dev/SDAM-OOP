using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public abstract class DatabaseManager
    {
        protected string connectionString = "Server=localhost;Database=coursedatabase;User ID=root;Password=yourpassword;SslMode=none;";

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Abstract methods to enforce CRUD structure
        public abstract DataTable Read();
        public abstract void Create(string name, string email, string extraData);
        public abstract void Update(int id, string name, string email, string extraData);
        public abstract void Delete(int id);

        // Helper method to execute queries with parameters
        protected void ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
