using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Models;
using UMS.Repositories;

namespace UMS.Controllers { 

    public class LoginController
    {
        private static string connectionString = "Data Source=users.db;Version=3;";

        public static string Login(string username, string password)
        {
            // Hardcoded Admin login
            if (username == "admin" && password == "admin123")
            {
                return "Admin";
            }

            // Check in SQLite DB
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT role FROM users WHERE name = @name AND password = @password";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString(); // Return role
                }
            }

            return null; // Login failed
        }
    }
}
