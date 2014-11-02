//Write a program that reads a string from the console and finds all products that contain this string.
//Ensure that you handle correctly characters like ', %, ", \ and _.

using System;
using System.Data.SqlClient;

class FindProductsContainingString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string escapedInput = input.Replace("'", "~'").Replace("%", "~%").Replace(@"\", @"~\").Replace("_", "~_");

        string serverName = "MSQLSERVER"; //Change this to your server
        string databaseName = "Northwind";
        string connectionString = string.Format("Server={0}; Database={1}; Integrated Security=true", serverName, databaseName);
        SqlConnection databaseConnection = new SqlConnection(connectionString);

        databaseConnection.Open();

        using (databaseConnection)
        {
            SqlCommand getAllProductsContainingInput = new SqlCommand("SELECT [ProductName] FROM [Products] WHERE [ProductName] LIKE ('%' + @input + '%') ESCAPE '~'", databaseConnection);
            getAllProductsContainingInput.Parameters.AddWithValue("@input", escapedInput);

            var productsContainingInput = getAllProductsContainingInput.ExecuteReader();

            while (productsContainingInput.Read())
            {
                Console.WriteLine("Product name: {0}{1}", productsContainingInput["ProductName"], Environment.NewLine);
            }
        }
    }
}
