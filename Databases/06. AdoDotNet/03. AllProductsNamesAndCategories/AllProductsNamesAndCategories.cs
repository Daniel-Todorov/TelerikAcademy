//Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.
//Can you do that with a single SQL query (with table join)?

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

class AllProductsNamesAndCategories
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
            SqlCommand getNamesOfCategoriesAndProducts = new SqlCommand("SELECT c.[CategoryName], p.[ProductName] FROM [Categories] c INNER JOIN [Products] p ON c.[CategoryID] = p.[CategoryID]", databaseConnection);
            var namesAndDescriptionsOfCategories = getNamesOfCategoriesAndProducts.ExecuteReader();

            Dictionary<string, string> aggregatedResults = new Dictionary<string, string>();
            while (namesAndDescriptionsOfCategories.Read())
            {
                string nameOfCategory = (string)namesAndDescriptionsOfCategories["CategoryName"];
                string nameOfProduct = (string)namesAndDescriptionsOfCategories["ProductName"];

                if (aggregatedResults.ContainsKey(nameOfCategory))
                {
                    aggregatedResults[nameOfCategory] += string.Format(", {0}", nameOfProduct);
                }
                else
                {
                    aggregatedResults.Add(nameOfCategory, nameOfProduct);
                }
            }

            foreach (var item in aggregatedResults)
            {
                Console.WriteLine("{0} => {1}{2}", item.Key, item.Value, Environment.NewLine);
            }
        }
    }
}