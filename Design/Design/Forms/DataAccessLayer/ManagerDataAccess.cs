using Design.Forms.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Forms.DataAccessLayer
{
    class ManagerDataAccess:DataAccess
    {
        public List<ManagerEntity> GetManager()
        {
            string sql = "SELECT * FROM Managers";
            SqlDataReader reader = this.GetData(sql);
            List<ManagerEntity> managers = new List<ManagerEntity>();
            while (reader.Read())
            {
                ManagerEntity manager = new ManagerEntity();
                manager.ManagerId = (int)reader["ManagerId"];
                manager.Name = reader["Name"].ToString();
                manager.Username = reader["Username"].ToString();
               
                managers.Add(manager);
            }
            return managers;
        }
        public ManagerEntity GetByManagerId(int managerId)
        {
            string sql = "SELECT * FROM Managers WHERE ManagerId=" + managerId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                ManagerEntity manager = new ManagerEntity();
                manager.ManagerId = (int)reader["ManagerId"];
                manager.Name = reader["Name"].ToString();
                manager.Username = reader["Username"].ToString();
                manager.Password = reader["Password"].ToString();
                return manager;
            }
            return null;

        }

        public bool AddManager(ManagerEntity manager)
        {
            string sql = "INSERT INTO Managers(Name,Username,Password) VALUES('" + manager.Name + "','" + manager.Username + "','" + manager.Password+ "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
      
        public bool DeleteManager(int managerId)
        {
            string sql = "DELETE FROM Managers WHERE ManagerId=" + managerId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

    }
}
