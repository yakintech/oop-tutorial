using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CsharpAdoNet.Env;
using CsharpAdoNet.Models;

namespace CsharpAdoNet.Manager
{
    public class SupplierManager
    {
        public SingletonDBConnection singletonDBConnection;

        public SupplierManager()
        {
            singletonDBConnection = SingletonDBConnection.getDbInstance();
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection sqlConnection = new SqlConnection(Connection.connectionString))
            {

                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand("select * from Suppliers", sqlConnection);

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Supplier supplier = new Supplier();

                        supplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                        supplier.CompanyName = reader["CompanyName"].ToString();
                        supplier.ContactName = reader["ContactName"].ToString();
                        supplier.ContactTitle = reader["ContactTitle"].ToString();

                        suppliers.Add(supplier);

                    }

                    sqlConnection.Close();

                    return suppliers;
                }
                catch (Exception ex)
                {
                    return suppliers;

                }



            }
        }


        public Supplier GetSupplierById(int id)
        {
            SqlConnection sqlConnection = singletonDBConnection.GetDbConnection();

            SqlCommand sqlCommand = new SqlCommand("select * from Suppliers where SupplierID = @supplierId", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@supplierId", id);

            var reader = sqlCommand.ExecuteReader();

            Supplier supplier = new Supplier();


            while (reader.Read())
            {
                supplier.CompanyName = reader["CompanyName"].ToString();
                supplier.ContactName = reader["ContactName"].ToString();

            }

            sqlConnection.Close();


            return supplier;
        }
    }
}
