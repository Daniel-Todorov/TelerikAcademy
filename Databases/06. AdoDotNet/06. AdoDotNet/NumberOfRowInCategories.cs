//Write a program that receives from the Northwind sample database in MS SQL Server the number of rows in the Categories table.

using System;
using System.Data.SqlClient;

class NumberOfRowInCategories
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
            SqlCommand getNumberOfRowsInCategories = new SqlCommand("SELECT COUNT ( * ) FROM [Categories]", databaseConnection);
            var numberOfRowsInCategories = getNumberOfRowsInCategories.ExecuteScalar();

            Console.WriteLine("The number of the rows in 'Categories' is: {0}.", numberOfRowsInCategories);
        }
    }
}
