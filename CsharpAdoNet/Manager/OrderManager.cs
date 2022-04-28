using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CsharpAdoNet.Models;

namespace CsharpAdoNet.Manager
{
    public class OrderManager
    {

        public SingletonDBConnection singletonDBConnection;

        public OrderManager()
        {
            singletonDBConnection = SingletonDBConnection.getDbInstance();
        }



        public List<Order> GetOrders()
        {
            var sqlConnection = singletonDBConnection.GetDbConnection();

            SqlCommand command = new SqlCommand("select * from Orders", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<Order> orders = MapSqlDataToOrders(reader);

            sqlConnection.Close();

            return orders;

          
        }


        public List<Order> GetOrders(string sortColumnName, string sortingType = "")
        {
            var sqlConnection = singletonDBConnection.GetDbConnection();

            SqlCommand command = new SqlCommand("select * from Orders order by " + sortColumnName + " " + sortingType, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<Order> orders = MapSqlDataToOrders(reader);

            sqlConnection.Close();

            return orders;
        }


        //Bu metot sql sonucunu alıp bana orderlistesi verir. 
        private List<Order> MapSqlDataToOrders(SqlDataReader reader)
        {
            List<Order> orders = new List<Order>();

            while (reader.Read())
            {
                Order order = new Order();

                order.OrderId = Convert.ToInt32(reader["OrderID"]);
                order.EmployeeId = Convert.ToInt32(reader["EmployeeID"]);
                order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                order.RequiredDate = Convert.ToDateTime(reader["RequiredDate"]);
                order.Freight = Convert.ToDecimal(reader["Freight"]);
                order.ShipCity = reader["ShipCity"].ToString();
                order.ShipCounty = reader["ShipCountry"].ToString();

                orders.Add(order);
            }

            return orders;
        }
    }
}
