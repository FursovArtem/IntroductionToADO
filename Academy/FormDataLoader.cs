using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    internal static class FormDataLoader
    {
        public static void LoadDataToComboBox(string tables, string column, ComboBox list, string condition = null, string default_value = null)
        {
            list.Items.Clear();
            if (default_value != null)
            { 
                list.Items.Add(default_value);
                list.SelectedIndex = 0;
            }
            Connector connector = new Connector();
            connector.LoadColumnFromTable(column, tables, condition);
            string[] items = new string[connector.DataTable.Rows.Count];
            for (int i = 0; i < items.Length; i++)
                items[i] = connector.DataTable.Rows[i][0].ToString();
            list.Items.AddRange(items);
        }
        public static void GroupFilter(ComboBox main, ComboBox dependent)
        {
            if (main.SelectedIndex > 0)
            {
                string condition = $"direction = direction_id AND direction_name='{main.SelectedItem.ToString()}'";
                LoadDataToComboBox("Groups, Directions", "group_name", dependent, condition);
            }
            else
            {
                LoadDataToComboBox("Groups", "group_name", dependent);
            }
        }
    }
}
