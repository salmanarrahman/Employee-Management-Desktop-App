using Design.Forms.Enitity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Forms.DataAccessLayer
{
    class CustomerDataAccess:DataAccess
    {
        public List<Customer> GetCustomers()
        {
            string sql = "SELECT * FROM CustomerData";
            SqlDataReader reader = this.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)reader["CustomerId"];
                customer.Name = reader["Name"].ToString();
                customer.Nationality = reader["Nationality"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.Gender = reader["Gender"].ToString();
                customer.MaritialStatus = reader["MaritialStatus"].ToString();
                
                customer.Email = reader["Email"].ToString();
                customer.AccountNumber = reader["AccountNumber"].ToString();
                customer.PhoneNumber= reader["PhoneNumber"].ToString();
                customer.Religion = reader["Religion"].ToString();
                customer.DateOfBirth = reader["DateOfBirth"].ToString();

                customers.Add(customer);
            }
            return customers;
        }

        public List<Customer> GetCustomerListById(int customerId)
        {
            string sql = "SELECT * FROM CustomerData WHERE CustomerId=" + customerId;
            SqlDataReader reader = this.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)reader["CustomerId"];
                customer.Name = reader["Name"].ToString();
                customer.Nationality = reader["Nationality"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.Gender = reader["Gender"].ToString();
                customer.MaritialStatus = reader["MaritialStatus"].ToString();

                customer.Email = reader["Email"].ToString();
                customer.AccountNumber = reader["AccountNumber"].ToString();
                customer.PhoneNumber = reader["PhoneNumber"].ToString();
                customer.Religion = reader["Religion"].ToString();
                customer.DateOfBirth = reader["DateOfBirth"].ToString();

                customers.Add(customer);
            }
            return customers;

        }

        public List<Customer> GetCustomerListByName(string str)
        {
            string sql = "SELECT * FROM CustomerData WHERE Name LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)reader["CustomerId"];
                customer.Name = reader["Name"].ToString();
                customer.Nationality = reader["Nationality"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.Gender = reader["Gender"].ToString();
                customer.MaritialStatus = reader["MaritialStatus"].ToString();

                customer.Email = reader["Email"].ToString();
                customer.AccountNumber = reader["AccountNumber"].ToString();
                customer.PhoneNumber = reader["PhoneNumber"].ToString();
                customer.Religion = reader["Religion"].ToString();
                customer.DateOfBirth = reader["DateOfBirth"].ToString();

                customers.Add(customer);
            }
            return customers;

        }

    }
}
