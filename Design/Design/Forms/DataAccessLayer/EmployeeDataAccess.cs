using Design.Forms.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Forms.DataAccessLayer
{
    class EmployeeDataAccess:DataAccess
    {
        public List<Employee> GetEmployees()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.Name = reader["Name"].ToString();
                employee.Nationality = reader["Nationality"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.MaritialStatus = reader["MaritialStatus"].ToString(); 
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Position = reader["Position"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employee.Religion = reader["Religion"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();

                employees.Add(employee);
            }
            return employees;
        }


        public Employee GetEmployeeById(int employeeId)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeId=" + employeeId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Employee employee= new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.Name = reader["Name"].ToString();
                employee.Nationality = reader["Nationality"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.MaritialStatus = reader["MaritialStatus"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Position = reader["Position"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employee.Religion = reader["Religion"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                return employee;
            }
            return null;

        }
        public List<Employee> GetEmployeeListById(int employeeId)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeId=" + employeeId;
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.Name = reader["Name"].ToString();
                employee.Nationality = reader["Nationality"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.MaritialStatus = reader["MaritialStatus"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Position = reader["Position"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employee.Religion = reader["Religion"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employees.Add(employee);
            }
            return employees;

        }
            public bool AddEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(Name,Email,DateOfBirth,Gender,BloodGroup,Religion,Nationality,MaritialStatus,Position,Salary,Address) VALUES('" + employee.Name + "','" + employee.Email + "','" + employee.DateOfBirth + "','" 
                + employee.Gender + "','" + employee.BloodGroup + "','" + employee.Religion + "','" + employee.Nationality + "','" + employee.MaritialStatus + "','" + employee.Position + "','" + employee.Salary + "','" + employee.Address + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool UpdateEmployee(Employee employee,int employeeId)
        {
            string sql = "UPDATE Employees SET Name='" + employee.Name + "',Email='" + employee.Email + "',DateOfBirth='" + employee.DateOfBirth + "',BloodGroup='" +employee.BloodGroup + "',Religion='" +employee.Religion + "',Nationality='" +employee.Nationality + "',MaritialStatus='" +employee.MaritialStatus + "',Position='" +employee.Position + "',Salary='" +employee.Salary + "',Address='" +employee.Address + "' WHERE EmployeeId=" + employeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool RemoveEmployee(int employeeId)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId=" + employeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Employee> GetEmployeeListByName(string str)
        {
            string sql = "SELECT * FROM Employees WHERE Name LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.Name = reader["Name"].ToString();
                employee.Nationality = reader["Nationality"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.MaritialStatus = reader["MaritialStatus"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Position = reader["Position"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employee.Religion = reader["Religion"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employees.Add(employee);
            }
            return employees;
        }

        public bool UpdateEmployeeSalary( int employeeId,string salary)
        {
            string sql = "UPDATE Employees SET Salary='" + salary + "'WHERE EmployeeId=" + employeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        /*
          public List<string> GetCategoryNames()
          {
              string sql = "SELECT * FROM Categories";
              SqlDataReader reader = this.GetData(sql);
              List<string> categories = new List<string>();
              while (reader.Read())
              {
                  categories.Add(reader["CategoryName"].ToString());
              }
              return categories;
          }
          */
        /*  public Employee GetEmployeeByName(string name)
          {
              string sql = "SELECT * FROM Employees WHERE Name='" + name + "'";
              SqlDataReader reader = this.GetData(sql);
              if (reader.HasRows)
              {
                  reader.Read();
                  Employee employee = new Employee();
                  employee.EmployeeId = (int)reader["EmployeeId"];
                  employee.Name = reader["Name"].ToString();
                  return employee;
              }
              return null;
        */
    }

    }

