using System.Data;
using System.Data.SqlClient;

namespace Library2
{
    internal class Library
    {
        string connectionString;

        SqlConnection connection;

        public SqlCommand cmd { get; set; }

        public Library(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }

        ~Library() 
        { 
            connection.Close();
        }

        public void InsertAuthor(string first_name, string last_name)
        {
            try 
            { 
                connection.Open();
                string command = 
                    $@"IF NOT EXISTS (SELECT author_id FROM Authors WHERE last_name = @paramLastName AND first_name = @paramFirstName)
                       BEGIN
                           INSERT INTO Authors
                               (last_name, first_name)
                           VALUES
                               (@paramLastName, @paramFirstName)
                       END";
                cmd = new SqlCommand(command, connection);
                // 1)
                /*SqlParameter parameterLastName = new SqlParameter("paramLastName", SqlDbType.NVarChar);
                SqlParameter parameterFirstName = new SqlParameter("paramFirstName", SqlDbType.NVarChar);
                parameterLastName.Value = last_name;
                parameterFirstName.Value = first_name;
                cmd.Parameters.Add(parameterLastName);
                cmd.Parameters.Add(parameterFirstName);*/
                // 2)
                /*SqlParameter[] values = new SqlParameter[]
                {
                    new SqlParameter("paramLastName", last_name),
                    new SqlParameter("paramFirstName", first_name)
                };
                cmd.Parameters.AddRange(values);*/
                // 3)
                cmd.Parameters.AddWithValue("paramLastName", last_name);
                cmd.Parameters.AddWithValue("paramFirstName", first_name);
                cmd.ExecuteNonQuery();
            } 
            finally
            {
                if(connection != null) connection.Close();
            }
        }

        public void InsertBook(string book_title, string author_first_name, string author_last_name, int pages, double price = 0)
        {
            InsertAuthor(author_first_name, author_last_name);
            try
            {
                connection.Open();
                string command = 
                    $@"IF NOT EXISTS (SELECT book_id FROM Books WHERE title = N'{book_title}')
                       BEGIN
                           DECLARE @Author SMALLINT = (SELECT author_id FROM Authors WHERE first_name = N'{author_first_name}' AND last_name = N'{author_last_name}')
                           INSERT INTO Books
                               (author, title, pages, price)
                           VALUES
                               (@Author, N'{book_title}', '{pages}', '{price}')
                       END";
                cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public void SelectAuthors()
        {
            try
            {
                connection.Open();
                string command = "SELECT * FROM Authors ORDER BY last_name, first_name";
                cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                System.Console.WriteLine($"{reader.GetName(0).PadRight(10)} {reader.GetName(1).PadRight(15)} {reader.GetName(2).PadRight(15)}");
                while (reader.Read())
                {
                    System.Console.WriteLine($"{reader[0].ToString().PadRight(10)} {reader[1].ToString().PadRight(15)} {reader[2].ToString().PadRight(15)}");
                }
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public void SelectBooks()
        {
            try
            {
                connection.Open();
                string command = $@"SELECT 
                                        [Author] = FORMATMESSAGE('%s %s', first_name, last_name),
                                        title AS Title
                                    FROM Books 
                                    JOIN Authors ON author = author_id
                                    ORDER BY first_name ASC, last_name ASC";
                cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                System.Console.WriteLine($"{reader.GetName(0).ToString().PadRight(50)} {reader.GetName(1).ToString().PadRight(50)}");
                System.Console.WriteLine();
                while (reader.Read())
                {
                    System.Console.WriteLine($"{reader[0].ToString().PadRight(50)} {reader[1].ToString().PadRight(50)}");
                }
            }
            finally 
            { 
                if(connection != null) connection.Close();
            }
        }

        public void SelectBooks(string first_or_last_name)
        {
            try
            {
                connection.Open();
                string command = $@"SELECT
                                        [Author] = FORMATMESSAGE('%s %s', first_name, last_name),
                                        title Title
                                    FROM Books
                                    JOIN Authors ON author = author_id
                                    WHERE first_name = N'{first_or_last_name}' OR last_name = N'{first_or_last_name}'
                                    ORDER BY first_name ASC, last_name ASC";
                cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                System.Console.WriteLine($"{reader.GetName(0).ToString().PadRight(50)} {reader.GetName(1).ToString().PadRight(50)}");
                System.Console.WriteLine();
                while (reader.Read())
                {
                    System.Console.WriteLine($"{reader[0].ToString().PadRight(50)} {reader[1].ToString().PadRight(50)}");
                }
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public void SelectBooks(string first_name, string last_name)
        {
            try
            {
                connection.Open();
                string command = $@"SELECT
                                        [Author] = FORMATMESSAGE('%s %s', first_name, last_name),
                                        title AS Title
                                    FROM Books
                                    JOIN Authors ON author = author_id
                                    WHERE (first_name = N'{first_name}' OR first_name = N'{last_name}')
                                        AND (last_name = N'{first_name}' OR last_name = N'{last_name}')
                                    ORDER BY first_name ASC, last_name ASC";
                cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                System.Console.WriteLine($"{reader.GetName(0).ToString().PadRight(50)} {reader.GetName(1).ToString().PadRight(50)}");
                System.Console.WriteLine();
                while (reader.Read())
                {
                    System.Console.WriteLine($"{reader[0].ToString().PadRight(50)} {reader[1].ToString().PadRight(50)}");
                }
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
    }
}
