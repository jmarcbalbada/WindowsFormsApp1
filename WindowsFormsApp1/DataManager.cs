using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static internal class DataManager
    {

        public static DataTable UserData { get; set; } = new DataTable();

        public static Dictionary<string, string> users = new Dictionary<string, string>();

        // Check if a username exists
        public static bool IsUsernameTaken(string username)
        {
            return users.ContainsKey(username);
        }

        public static bool AddUser(string username, string password)
        {
            if (!IsUsernameTaken(username))
            {
                users.Add(username, password);
                return true;
            }
            return false;
        }

        // Initialize columns once
        static DataManager()
        {
            UserData.Columns.Add("Name");
            UserData.Columns.Add("Address");
            UserData.Columns.Add("Email");
            UserData.Columns.Add("Age");
            UserData.Columns.Add("Username");
            UserData.Columns.Add("Password");
            UserData.Columns.Add("Saying");
            UserData.Columns.Add("Color");
            UserData.Columns.Add("Gender");
            UserData.Columns.Add("Sport");
            UserData.Columns.Add("Birthday");

        }
    }
}
