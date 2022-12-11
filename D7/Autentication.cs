using D7.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7
{
    public static class Autentication
    {
        private static readonly string connection_string = "Server=tcp:polibits-pegasus.database.windows.net,1433;Initial Catalog=DB;Persist Security Info=False;User ID=pegasus_adm;Password=#Minecraft123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private static List<User> Users = new List<User>();
        public static bool AutenticateUser(string username, string password)
        {
            LoadUsers();
            foreach (var user in Users)
            {
                if(user.name == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void LoadUsers()
        {
            using(SqlConnection con = new SqlConnection(connection_string))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Name, Password FROM USERS_CTEDS_D7", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string Name = rdr["Name"].ToString();
                    string Password = rdr["Password"].ToString();
                    Users.Add(new User(Name, Password));
                }
            }
        }
    }
}