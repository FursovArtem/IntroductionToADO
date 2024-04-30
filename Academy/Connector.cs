using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Connector
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        public DataTable DataTable { get; set; }
        public Connector()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public DataTable LoadColumnFromTable(string columns, string tables, string condition = null)
        {
            connection.Open();
            string query = $@"SELECT {columns} FROM {tables}";
            if (condition != null && !condition.Contains("Все")) query += $" WHERE {condition}";
            SqlCommand command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            DataTable = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++) DataTable.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row = DataTable.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                DataTable.Rows.Add(row);
            }
            connection.Close();
            return DataTable;
        }
        public void InsertDataToBase(string table, string columns, string values)
        {
            string command = $@"INSERT INTO {table}({columns}) VALUES ({values})";
            Console.WriteLine(command);
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public int GetIDByValue(string table, string columns, string value)
        {
            string command = $"SELECT {columns.Split(',')[0]} FROM {table} WHERE {columns.Split(',')[1]}='{value}'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return id;
        }
        public void UpdateImage(string table, string field, byte[] image_bytes, string condition)
        {
            string command = $"UPDATE {table} SET {field} = @image WHERE {condition}";
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = image_bytes;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public Image LoadImage(string table, string field, string condition)
        {
            byte[] b = null;
            string command = $"SELECT {field} FROM {table} WHERE {condition}";
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                    b = (byte[])reader.GetValue(0);
            }
            connection.Close();
            if (b != null)
            {
                MemoryStream ms = new MemoryStream(b);
                //ms.Seek(0, SeekOrigin.Begin);
                Image image = Image.FromStream(ms);
                return image;
            }
            else return null;
        }
        public void UpdateDataInBase(string table, string columns, string values, string condition)
        {
            string[] columns_splited = columns.Split(',');
            string[] values_splited = values.Split(',');
            string[] expressions_splited = new string[columns_splited.Length];
            string expressions = "";
            for (int i = 0; i < columns_splited.Length; i++)
            {
                expressions_splited[i] = $"{columns_splited[i]} = {values_splited[i]}";
                expressions += $" {expressions_splited[i]},";
            }
            expressions = expressions.Remove(expressions.Length - 1);
            string command = $@"UPDATE {table} SET {expressions} WHERE {condition}";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public int GetMaxValue(string table, string column) 
        {
            string command = $"SELECT MAX({column}) FROM {table}";
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            int max = (int)cmd.ExecuteScalar();
            connection.Close();
            return max;
        }
    }
}
