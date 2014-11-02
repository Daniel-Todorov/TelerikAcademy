//Implement appending new rows to the Excel file.

using System;
using System.Data.OleDb;

class AddNewRowToExcel
{
    static void Main()
    {
        OleDbConnection databaseConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=records.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");

        databaseConnection.Open();

        using (databaseConnection)
        {
            OleDbCommand insertRecord = new OleDbCommand("INSERT INTO [Sheet1$] ([Name], [Score]) VALUES ('Ivan Todorov', 999)", databaseConnection);            

            var result = insertRecord.ExecuteNonQuery();

            Console.WriteLine(result);
        }
    }
}
