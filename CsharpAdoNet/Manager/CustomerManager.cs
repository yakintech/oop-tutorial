using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CsharpAdoNet.Models;

namespace CsharpAdoNet.Manager
{
    public class CustomerManager
    {
        public SingletonDBConnection singletonDBConnection;

        public CustomerManager()
        {
            singletonDBConnection = SingletonDBConnection.getDbInstance();
        }


        public List<Customer> GetCustomers(string query)
        {
            SqlConnection sqlConnection = singletonDBConnection.GetDbConnection();

            SqlCommand command = new SqlCommand(query, sqlConnection);

            var reader = command.ExecuteReader();

            List<Customer> customers = MapSqlDataToCustomers(reader);


            sqlConnection.Close();

            return customers;
        }


        public List<Customer> MapSqlDataToCustomers(SqlDataReader sqlDataReader)
        {
            List<Customer> customers = new List<Customer>();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();

                customer.CustomerID = sqlDataReader["CustomerID"].ToString();
                customer.CompanyName = sqlDataReader["CompanyName"].ToString();
                customer.ConcatName = sqlDataReader["ContactName"].ToString();

                customers.Add(customer);
            }

            return customers;

        }
    }
}
