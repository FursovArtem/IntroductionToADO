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
            //library.InsertAuthor("Randy", "Gage; CREATE TABLE Guys (id INT PRIMARY KEY, name NVARCHAR(50))");
            library.SelectAuthors();
            Console.WriteLine();
            library.SelectBooks();
        }
    }
}
