﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CsharpAdoNet.Env;
using CsharpAdoNet.Models;

namespace CsharpAdoNet.Manager
{
    public class ProductManager
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
  
            using (SqlConnection sqlConnection = new SqlConnection(Connection.connectionString))
            {

                try
                {
                    sqlConnection.Open();


                    SqlCommand cmd = new SqlCommand("select * from Products", sqlConnection);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product product = new Product();

                        product.Id = Convert.ToInt32(reader["ProductId"]);
                        product.Name = reader["ProductName"].ToString();
                        product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                        product.UnitsInStock = Convert.ToInt32(reader["UnitsInStock"]);

                        products.Add(product);

                    }


                    sqlConnection.Close();

                    return products;
                }
                catch (Exception ex)
                {
                    return products;
                }

            }
        }


        public Product GetProductById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection.connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string queryString = "select * from Products where ProductID = @productId";

                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@productId", id);

                    var reader = sqlCommand.ExecuteReader();

                    Product product = new Product();

                    while (reader.Read())
                    {
                        
                        product.Id = Convert.ToInt32(reader["ProductID"]);
                        product.Name = reader["ProductName"].ToString();
                        product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                        product.UnitsInStock = Convert.ToInt32(reader["UnitsInStock"]);
                    }

                    sqlConnection.Close();
                    return product;
                }
                catch (Exception ex)
                {
                    throw ;
                }

            }
        }
    }
}
