using System;

namespace Library2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"
Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=LibraryPD_321;
Integrated Security=True;
Connect Timeout=30;
Encrypt=False;
TrustServerCertificate=False;
ApplicationIntent=ReadWrite;
MultiSubnetFailover=False";
            Library library = new Library(connectionString);
            //library.InsertAuthor("Joe", "Abercrombie");
            //library.InsertBook("Преступление и наказание", "Фёдор", "Достоевский", 672, 222);
            library.InsertBook("Harry Potter and the Philosopher''s Stone", "Joanne", "Rowling", 352, 100);
            library.InsertBook("Harry Potter and the Chamber of Secrets", "Joanne", "Rowling", 480, 111);
            library.SelectAuthors();
            Console.WriteLine();
            library.SelectBooks();
            Console.WriteLine();
            //library.SelectBooks();
        }
    }
}
