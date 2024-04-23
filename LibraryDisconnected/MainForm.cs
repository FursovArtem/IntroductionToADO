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

namespace LibraryDisconnected
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet set;
        SqlCommandBuilder cmd;
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            set = new DataSet();

            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.Text = "SELECT * FROM Authors";

            LoadTablesFromBase();
        }

        void LoadTablesFromBase()
        {
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            adapter = new SqlDataAdapter(query, connection);
            cmd = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "tables");
            DataRow[] tableNames = new DataRow[set.Tables["tables"].Rows.Count];
            set.Tables["tables"].Rows.CopyTo(tableNames, 0);
            for (int i = 0; i < tableNames.Length; i++)
            {
                string tableName = tableNames[i].ItemArray[0].ToString();
                query = $"SELECT * FROM {tableName}";
                adapter.SelectCommand.CommandText = query;
                adapter.Fill(set, tableName);
                comboBoxTables.Items.Add(tableName);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string query = richTextBox.Text;
            adapter = new SqlDataAdapter(query, connection);
            cmd = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "myTable");
            dataGridView.DataSource = set.Tables["myTable"];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(set, "myTable");
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = set.Tables[comboBoxTables.SelectedItem.ToString()];
        }
    }
}
