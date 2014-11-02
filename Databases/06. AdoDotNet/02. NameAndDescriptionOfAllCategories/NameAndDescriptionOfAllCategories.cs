//Write a program that retrieves the names and descriptions of all cathegories in the Northwind DB.

using System;
using System.Data.SqlClient;

class NameAndDescriptionOfAllCategories
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
            SqlCommand getNamesAndDescriptionsOfCategories = new SqlCommand("SELECT [CategoryName], [Description] FROM [Categories]", databaseConnection);
            var namesAndDescriptionsOfCategories = getNamesAndDescriptionsOfCategories.ExecuteReader();

            while (namesAndDescriptionsOfCategories.Read())
            {
                string nameOfCategory = (string) namesAndDescriptionsOfCategories["CategoryName"];
                string descriptionOfCategory = (string)namesAndDescriptionsOfCategories["Description"];

                Console.WriteLine("Category: '{0}' => Description: '{1}'{2}", nameOfCategory, descriptionOfCategory, Environment.NewLine);
            }
        }
    }
}
