//Download and install MySQL database, MySQL Connector/Net (.NET Data Provider for MySQL) + MySQL Workbench GUI administration tool.
//Create  a MySQL database to store Books (title, author, public date and ISBN).
//Write methods for listng all books, finding a book by name and adding a book.

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class UseMySQLWithAdoDotNet
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string serverName = "localhost"; //Change this to your server
        string databaseName = "library"; //Change this to your database
        string port = "3306"; //Change this to your port
        string user = "root"; //Change this to your user
        string password = "xxxxx"; //Change this to your password
        string connectionString = string.Format("Server={0}; Port={1}; Database={2}; Uid={3}; Pwd={4}; pooling=true", serverName, port, databaseName, user, password);
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        AddBook(databaseConnection);

        FindBookByName(databaseConnection);

        ListAllBooks(databaseConnection);
    }

    private static void ListAllBooks(MySqlConnection connection)
    {
        connection.Open();
        using (connection)
        {
            MySqlCommand listAllBooks = new MySqlCommand("SELECT * FROM books", connection);

            var result = listAllBooks.ExecuteReader();

            ListBooks(result);
        }
    }

    private static void ListBooks(MySqlDataReader collectionOfBooks)
    {
        if (collectionOfBooks.FieldCount <= 0)
        {
            Console.WriteLine("No books found!");
        }
        else
        {
            while (collectionOfBooks.Read())
            {
                Console.WriteLine("Title: {0} | Author: {1} | Date published: {2} | ISBN: {3}{4}", collectionOfBooks["book_title"], collectionOfBooks["book_author"], collectionOfBooks["book_date_published"], collectionOfBooks["book_isbn"], Environment.NewLine);
            }
        }
    }

    private static void FindBookByName(MySqlConnection connection)
    {
        Console.Write("Search for books with title: ");
        string searchTerm = Console.ReadLine();

        connection.Open();
        using (connection)
        {

            MySqlCommand listResults = new MySqlCommand("SELECT * FROM books WHERE book_title LIKE '%" + searchTerm + "%'", connection); //It gives some wierd error if I try to do it with parameters.

            var result = listResults.ExecuteReader();

            ListBooks(result);
        }
    }

    private static void AddBook(MySqlConnection connection)
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Publish date: ");
        DateTime publishDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();

        connection.Open();
        using (connection)
        {
            MySqlCommand insertBook = new MySqlCommand("INSERT INTO books (book_title, book_author, book_date_published, book_isbn) VALUES (@title, @author, @publishDate, @isbn)", connection);
            insertBook.Parameters.AddWithValue("@title", title);
            insertBook.Parameters.AddWithValue("@author", author);
            insertBook.Parameters.AddWithValue("@publishDate", publishDate);
            insertBook.Parameters.AddWithValue("@isbn", isbn);

            try
            {
                int result = insertBook.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Book added!");
                }
                else
                {
                    Console.WriteLine("Book was NOT added!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured while trying to add the book! => {0}", e.Message);
            }

        }
    }
}