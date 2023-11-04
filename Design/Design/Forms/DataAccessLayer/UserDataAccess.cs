using Design.Forms.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Forms.DataAccessLayer
{
    class UserDataAccess:DataAccess
    {
        public bool AddAdmin(Admin admin)
        {
            string sql = "INSERT INTO Admins(Name,Username,Password) VALUES('" + admin.Name + "','" + admin.UserName + "','" + admin.Password + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool LoginValidationAdmin(string username, string password)
        {
            string sql = "SELECT * FROM Admins WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }
        public bool LoginValidationManager(string username, string password)
        {
            string sql = "SELECT * FROM Managers WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }

    }

}

