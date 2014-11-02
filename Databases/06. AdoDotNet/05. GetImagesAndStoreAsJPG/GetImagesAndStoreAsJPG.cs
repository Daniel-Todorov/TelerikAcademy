//Write a program that retreives the images for all categories in the northwind database and store them as JPG files in the file system.

using System;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;

class GetImagesAndStoreAsJPG
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
            SqlCommand getPictures = new SqlCommand("SELECT [CategoryName], [Picture] FROM [Categories]", databaseConnection);
            SqlDataReader categoryNamesAndPictures = getPictures.ExecuteReader();

            while (categoryNamesAndPictures.Read())
            {
                byte[] rawImage = (byte[])categoryNamesAndPictures["Picture"];
                int lengthOfRawData = rawImage.Length;
                int uselessHeader = 78;
                byte[] fixedImage = new byte[lengthOfRawData - uselessHeader];
                Array.Copy(rawImage, 78, fixedImage, 0, lengthOfRawData - uselessHeader);

                string fileName = categoryNamesAndPictures["CategoryName"].ToString().Replace('/', '_') + ".jpg";
                FileStream stream = File.OpenWrite(fileName);

                using (stream)
                {
                    stream.Write(fixedImage, 0, fixedImage.Length);
                }
            }
        }
    }
}
