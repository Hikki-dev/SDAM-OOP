using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Course_Managment_APP
{
    public abstract class User
    {
        // Encapsulation: Private fields with protected access
        protected int UserID { get; set; }
        protected string Name { get; set; }
        protected string Email { get; set; }
        protected string Role { get; set; }

        protected string connectionString = "Server=localhost;Database=coursedatabase;User ID=root;Password=yourpassword;SslMode=none;";


        // Constructor
        public User(string email)
        {
            this.Email = email;
        }

        // Abstraction: Method for login to be implemented in derived classes
        public abstract void Login(string password);
    }
}
