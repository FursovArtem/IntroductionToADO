using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Library3
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            MessageBox.Show(this, connection.ConnectionString, "ConnectionString", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBoxQuery.SelectAll();
            richTextBoxQuery.SelectionAlignment = HorizontalAlignment.Center;

            connection.Open();
            table = connection.GetSchema("Tables");
            foreach (DataRow row in table.Rows) comboBoxTables.Items.Add(row[2]);
            connection.Close();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string cmdLine = richTextBoxQuery.Text;
            SqlCommand cmd = new SqlCommand(cmdLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
            connection.Close();
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdLine = $"SELECT * FROM {comboBoxTables.SelectedItem}";
            SqlCommand cmd = new SqlCommand(cmdLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
            connection.Close();
        }
    }
}
