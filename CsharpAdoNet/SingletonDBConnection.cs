using System;
using System.Data.SqlClient;
using CsharpAdoNet.Env;

namespace CsharpAdoNet
{
    public class SingletonDBConnection
    {
        private static SingletonDBConnection dbInstance;

        private readonly SqlConnection sqlConnection = new SqlConnection(Connection.connectionString);


        private SingletonDBConnection()
        {

        }

        public static SingletonDBConnection getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new SingletonDBConnection();
            }

            return dbInstance;
        }



        public SqlConnection GetDbConnection()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {

            }

            return sqlConnection;
        }

        
    }
}
