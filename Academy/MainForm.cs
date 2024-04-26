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
using System.Collections.Specialized;
using System.IO;

namespace Academy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadStudents();
            FormDataLoader.LoadDataToComboBox("Groups", "group_name", comboBoxStudentsGroup, null, "Все");
            FormDataLoader.LoadDataToComboBox("Directions", "direction_name", comboBoxStudentsDirection, null, "Все");
        }

        void LoadStudents(string condition = null)
        {
            string column = $@"
				[ID] = stud_id,
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
            dataGridViewStudents.Columns[0].Visible = false;
            setStatus();
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
                toolStripStatusLabelGroupsCount.Text = $"Всего групп: {comboBoxStudentsGroup.Items.Count}";
            }
            else
            {
                toolStripStatusLabelGroupsCount.Text = $"Групп по выбранному направлению: {comboBoxStudentsGroup.Items.Count}";
            }
        }

        private void comboBoxStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxStudentsGroup.Items.Clear();
            FormDataLoader.GroupFilter(comboBoxStudentsDirection, comboBoxStudentsGroup);
            LoadStudents($"direction_name = '{comboBoxStudentsDirection.SelectedItem.ToString()}'");
            setStatus();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            DialogResult result = formStudent.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void dataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Connector connector = new Connector();
            connector.LoadColumnFromTable("*", "Students", $"stud_id = {dataGridViewStudents.SelectedCells[0].Value}");
            List<string> items = new List<string>();
            for (int i = 0; i < connector.DataTable.Columns.Count; i++)
                items.Add(connector.DataTable.Rows[0][i].ToString());
            //
            connector.LoadColumnFromTable("group_name, direction", "Groups", $"group_id = {items[8]}");
            items[8] = connector.DataTable.Rows[0][0].ToString();
            string direction_id = connector.DataTable.Rows[0][1].ToString();
            connector.LoadColumnFromTable("direction_name", "Directions", $"direction_id = {direction_id}");
            items.Add(connector.DataTable.Rows[0][0].ToString());
            //
            DateTime birth_date = DateTime.Parse(items[4]);
            //byte[] imageBytes = Encoding.Unicode.GetBytes(items[7]);
            //MemoryStream ms = new MemoryStream(imageBytes);
            //Image img = Image.FromStream(ms);
            //
            FormStudent form = new FormStudent();
            form.InitForm(items[1], items[2], items[3], birth_date, items[5], items[6], items[8], items[9]);
            form.ShowDialog();
        }
    }
}