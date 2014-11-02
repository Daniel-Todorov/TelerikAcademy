namespace ConsoleClient
{
    using BookStoreModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class ConsoleClient
    {
        public static void Main()
        {
            //var db = new BookStoreEntities();

            //db.Authors.Add(new Author() { Name = "Ivan" });

            //db.SaveChanges();

            var document = XDocument.Load("complex-books.xml");

            var books = document.Descendants("book");
            List<Book> list = new List<Book>();

            foreach (var book in books)
            {
                var newBook = new Book();
                if (book.Element("title") != null)
                {
                    newBook.Title = book.Element("title").Value;
                }
                else
                {
                    throw new ArgumentNullException("A book title is missing!");
                }
                newBook.ISBN = book.Element("isbn") == null ? null : book.Element("isbn").Value;
                if (book.Element("price") != null)
                {
                    newBook.Price = decimal.Parse(book.Element("price").Value);
                } else {
                    newBook.Price = null;
                }
                newBook.Website = book.Element("web-site") == null ? null : book.Element("web-site").Value;

                var authors = book.Descendants("author");
                foreach (var author in authors)
                {
                    newBook.Authors.Add(new Author() { Name = author.Value });
                }

                var reviews = book.Descendants("review");
                foreach (var review in reviews)
                {
                    var newReview = new Review();
                    if (review.Attribute("date") != null)
                    {
                        newReview.DateOfCreation = DateTime.Parse(review.Attribute("date").Value);
                    }
                    else
                    {
                        newReview.DateOfCreation = DateTime.Now;
                    }

                    newReview.Author = review.Attribute("author") == null ? null : new Author() { Name = review.Attribute("author").Value };
                    newReview.Content = review.Value;

                    newBook.Reviews.Add(newReview);
                }

                list.Add(newBook);
            }
            //document.Elements
        }
    }
}
