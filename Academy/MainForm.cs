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
using System.Runtime.InteropServices;

namespace Academy
{
	public partial class MainForm : Form
	{
		//string connectionString;
		//SqlConnection connection;
		//SqlDataReader reader;
		//DataTable table;
		public MainForm()
		{
			InitializeComponent();
			//connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			//if (AllocConsole())
			//{
			//	Console.WriteLine(connectionString);
			//	//FreeConsole();
			//}
			//connection = new SqlConnection(connectionString);
			LoadStudents();
			LoadDataToComboBox("Groups", "group_name", comboBoxStudentsGroup);
			LoadDataToComboBox("Directions", "direction_name", comboBoxStudentsDirection);
		}

		void LoadStudents(string condition = null)
		{
			string column = $@"
[Ф.И.О.] = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name),
[Дата рожения] = birth_date,
[Группа] = group_name,
[Направление] = direction_name";
			string tables = "students, groups, directions";
			string relations = "Students.[group]=group_id AND direction=direction_id";
			if (condition != null && !condition.Contains("Все")) condition = $@"{relations} AND {condition}";
			else condition = relations;
			Connector connector = new Connector();
			dataGridViewStudents.DataSource = connector.LoadColumnFromTable(column, tables, condition);
        }
		void LoadDataToComboBox(string tables, string column, ComboBox list, string condition = null)
		{
			list.Items.Clear();
			list.Items.Add("Все");
			list.SelectedIndex = 0;
			Connector connector = new Connector();
			connector.LoadColumnFromTable(column, tables, condition);
			string[] items = new string[connector.DataTable.Rows.Count];
			for (int i = 0; i < items.Length; i++)
				items[i] = connector.DataTable.Rows[i][0].ToString();
			list.Items.AddRange(items);
		}
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool FreeConsole();

		private void comboBoxStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadStudents($"group_name = '{comboBoxStudentsGroup.SelectedItem.ToString()}'");
			setStatus();
		}
		private void setStatus()
		{
			toolStripStatusLabelStudentsCount.Text = $"Количество студентов: {dataGridViewStudents.RowCount - 1}";
			if (comboBoxStudentsDirection.SelectedItem?.ToString() == "Все")
			{
				toolStripStatusLabelGroupsCount.Text = $"Всего групп: {comboBoxStudentsGroup.Items.Count - 1}";
			}
			else
			{
				toolStripStatusLabelGroupsCount.Text = $"Групп по выбранному направлению: {comboBoxStudentsGroup.Items.Count - 1}";
			}
		}

		private void comboBoxStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			//comboBoxStudentsGroup.Items.Clear();
			if (comboBoxStudentsDirection.SelectedIndex > 0)
			{
				string condition = $"direction = direction_id AND direction_name='{comboBoxStudentsDirection.SelectedItem.ToString()}'";
				LoadDataToComboBox("Groups, Directions", "group_name", comboBoxStudentsGroup, condition);
			}
			else
			{
				LoadDataToComboBox("Groups", "group_name", comboBoxStudentsGroup);
			}
			LoadStudents($"direction_name = '{comboBoxStudentsDirection.SelectedItem.ToString()}'");
			setStatus();
		}

		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			FormStudent formStudent = new FormStudent();
			formStudent.ShowDialog();
		}
	}
}