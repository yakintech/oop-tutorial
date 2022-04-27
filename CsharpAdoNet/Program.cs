using System;
using System.Data.SqlClient;
using CsharpAdoNet.Manager;

namespace CsharpAdoNet
{
    //AYNI İŞLEMİ SUPPLİER İLE YAP
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            Console.WriteLine("Lütfen istediğiniz ürünün ID sini giriniz");

            int productId = Convert.ToInt32(Console.ReadLine());


            var product = productManager.GetProductById(productId);

            Console.WriteLine("Name: " + product.Name);
            Console.WriteLine("UnitPrice: " + product.UnitPrice);
            Console.WriteLine("Stock: " + product.UnitsInStock);

            Console.Read();


            //var products = productManager.GetAllProducts();


            //SupplierManager supplierManager = new SupplierManager();

            //var suppliers = supplierManager.GetAllSuppliers();

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
