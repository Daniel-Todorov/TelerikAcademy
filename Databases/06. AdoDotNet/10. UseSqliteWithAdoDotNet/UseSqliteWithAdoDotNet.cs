//Re-implement the previous task with SQLite embedded DB.

    using System;
    using System.Data.SQLite;
    using System.Text.RegularExpressions;

public class UseSqliteWithAdoDotNet
{
    private static SQLiteConnection dbCon;

    public static void Main()
    {
        dbCon = new SQLiteConnection("Data Source=Books.sqlite;Version=3;");

        dbCon.Open();

        using (dbCon)
        {
            string search = "%";
            FindBooks(search);

            ListAllBooks();

            InsertBook("Test Book Number One", "Pesho Petrov", "123435", new DateTime(2013, 07, 01));
        }

    }

    private static void InsertBook(string title, string author, string isbn, DateTime publishDate)
    {
        SQLiteCommand query = new SQLiteCommand("Insert Into Books(Title, Author, ISBN, PublishDate) VALUES(@Title, @Author, @ISBN, @PublishDate)", dbCon);
        query.Parameters.AddWithValue("@Title", title);
        query.Parameters.AddWithValue("@Author", author);
        query.Parameters.AddWithValue("@ISBN", isbn);
        query.Parameters.AddWithValue("@PublishDate", publishDate);

        query.ExecuteNonQuery();
        Console.WriteLine("Book: {0}, Successfully added!", title);

    }

    private static void ListAllBooks()
    {
        SQLiteCommand query = new SQLiteCommand("SELECT Books.Title FROM Books", dbCon);

        SQLiteDataReader reader = query.ExecuteReader();

        using (reader)
        {
            Console.WriteLine("All Books:");
            while (reader.Read())
            {
                Console.WriteLine("Book:" + (string)reader["Title"]);
            }
        }
    }

    private static void FindBooks(string searchedString)
    {
        string escapeString = "/";
        searchedString = searchedString.Replace("%", escapeString + "%");
        searchedString = searchedString.Replace("_", escapeString + "_");
        searchedString = searchedString.Replace("\\", escapeString + "\\");

        SQLiteCommand query = new SQLiteCommand("SELECT Books.Title FROM Books WHERE Books.Title LIKE '%" + searchedString + "%' ESCAPE '" + escapeString + "' ", dbCon);
        query.Parameters.AddWithValue("@input", searchedString);

        SQLiteDataReader reader = query.ExecuteReader();

        using (reader)
        {
            Console.WriteLine("Books Found:");
            while (reader.Read())
            {
                Console.WriteLine("Book:" + (string)reader["Title"]);
            }
        }
    }
}