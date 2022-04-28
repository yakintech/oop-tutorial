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

            var reader = command.ExecuteReader();

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

            sqlConnection.Close();

            return orders;



          
        }

    }
}
