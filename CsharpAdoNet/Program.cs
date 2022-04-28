using System;
using System.Data.SqlClient;
using CsharpAdoNet.Manager;
using CsharpAdoNet.Models;

namespace CsharpAdoNet
{
    //AYNI İŞLEMİ SUPPLİER İLE YAP
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            var customers = customerManager.GetCustomers("select * from Customers order by ContactName desc");




            OrderManager orderManager = new OrderManager();

            var orders = orderManager.GetOrders();



            SupplierManager supplierManager = new SupplierManager();

            Supplier supplier = supplierManager.GetSupplierById(4);

            //var singletonInstance =  SingletonDBConnection.getDbInstance();
            //var singletonInstance2 = SingletonDBConnection.getDbInstance();
            //var singletonInstance3 = SingletonDBConnection.getDbInstance();



            ProductManager productManager = new ProductManager();

            productManager.SearchName("ton");

            productManager.GetProductsCount();
           // productManager.DeleteProduct(78);

            var products = productManager.GetAllProducts();

            //#region
            //Product newProduct = new Product();
            //newProduct.Name = "IPhone";
            //newProduct.UnitPrice = 55;
            //newProduct.UnitsInStock = 2;


            //productManager.AddProduct(newProduct);

           


            //Console.WriteLine("Lütfen istediğiniz ürünün ID sini giriniz");

            //int productId = Convert.ToInt32(Console.ReadLine());


            //var product = productManager.GetProductById(productId);

            //Console.WriteLine("Name: " + product.Name);
            //Console.WriteLine("UnitPrice: " + product.UnitPrice);
            //Console.WriteLine("Stock: " + product.UnitsInStock);

            //Console.Read();

            //#endregion




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
