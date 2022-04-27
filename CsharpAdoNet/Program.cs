using System;
using System.Data.SqlClient;
using CsharpAdoNet.Manager;

namespace CsharpAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            var products = productManager.GetAllProducts();

            //string connectionString = "Server=94.73.145.4;Database=u9751868_db9EC;User Id=u9751868_user9EC;Password=PWtw68S5BRcg01S;";


            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //SqlCommand cmd = new SqlCommand("select * from Products", sqlConnection);


            //sqlConnection.Open();

            //var result = cmd.ExecuteReader();

            //while (result.Read())
            //{
            //    //Console.WriteLine(result["ProductName"]);
            //    Console.WriteLine(result[0]);

            //}

            //Console.Read();

            //sqlConnection.Close();

            

        }
    }
}
