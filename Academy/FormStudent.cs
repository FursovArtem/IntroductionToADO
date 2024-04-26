using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academy
{
	public partial class FormStudent : Form
	{
		public FormStudent()
		{
			InitializeComponent();
			FormDataLoader.LoadDataToComboBox("Directions", "direction_name", comboBoxDirection, null, "Все");
			FormDataLoader.LoadDataToComboBox("Groups", "group_name", comboBoxGroup);
		}
		public void InitForm(string last_name, string first_name, string middle_name, DateTime birth_date, string email, string phone, string group, string direction, Image photo = null)
		{
			richTextBoxLastName.Text = last_name;
			richTextBoxFirstName.Text = first_name;
			richTextBoxMiddleName.Text = middle_name;
			dateTimePickerBirthDate.Value = birth_date;
			richTextBoxEmail.Text = email;
			richTextBoxPhone.Text = phone;
			comboBoxGroup.SelectedIndex = comboBoxGroup.FindStringExact(group);
			comboBoxDirection.SelectedIndex = comboBoxDirection.FindStringExact(direction);
			pictureBoxPhoto.Image = photo;
			comboBoxGroup.Enabled = false;
		}
        private void buttonSave_Click(object sender, EventArgs e)
        {
			Connector connector = new Connector();
			connector.InsertDataToBase("Students",
				"last_name, first_name, middle_name, birth_date, email, phone, photo, [group]",
				$"'{richTextBoxLastName.Text}', '{richTextBoxFirstName.Text}', '{richTextBoxMiddleName.Text}', " +
				$"'{dateTimePickerBirthDate.Value}', '{richTextBoxEmail.Text}', '{richTextBoxPhone.Text}', " +
				$"'{pictureBoxPhoto.Image}', {connector.GetIDByValue("Groups", "group_id,group_name", comboBoxGroup.SelectedItem.ToString())}");
        }

        private void buttonBrows_Click(object sender, EventArgs e)
        {
			OpenFileDialog open = new OpenFileDialog();
			open.ShowDialog();
			string filename = open.FileName;
			pictureBoxPhoto.Image = Image.FromFile(filename);
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
			FormDataLoader.GroupFilter(comboBoxDirection, comboBoxGroup);
        }
    }
}
