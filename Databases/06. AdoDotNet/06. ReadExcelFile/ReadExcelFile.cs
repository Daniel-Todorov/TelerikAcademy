//Create an Excel file with two columns: name and score.
//Write a program that reads your MS Excel file through OLE DB data provider and displays the name and score row by row.

using System;
using System.Data.OleDb;

class ReadExcelFile
{
    static void Main()
    {
        OleDbConnection databaseConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=records.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");

        databaseConnection.Open();

        using (databaseConnection)
        {
            OleDbCommand getInfo = new OleDbCommand("SELECT * FROM [Sheet1$]", databaseConnection);

            var result = getInfo.ExecuteReader();

            while (result.Read())
            {
                string name = (string)result["Name"];
                double score = (double)result["Score"];
                Console.WriteLine("{0} => {1} scores", name, score);
            }
        }
    }
}
