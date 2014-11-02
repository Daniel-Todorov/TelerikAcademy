//Write a method that adds a new product int the products table in the Northwind database.
//Use a parameterized SQL command.

using System;
using System.Data.SqlClient;

class AddNewProduct
{
    static void Main()
    {
        string serverName = "MSSQLSERVER"; //Change this to your server
        string databaseName = "Northwind";
        string connectionString = string.Format("Server={0}; Database={1}; Integrated Security=true", serverName, databaseName);
        SqlConnection databaseConnection = new SqlConnection(connectionString);

        databaseConnection.Open();

        using (databaseConnection)
        {
            SqlCommand insertProduct = new SqlCommand("INSERT INTO [Products] ([ProductName])" +
                "VALUES (@productName)", databaseConnection);
            insertProduct.Parameters.AddWithValue("@productName", "Saltsticks with apple jam");

            Console.WriteLine("Number of rows affected: {0}", insertProduct.ExecuteNonQuery());
        }
    }
}
