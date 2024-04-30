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
        int id;
        public FormStudent()
        {
            InitializeComponent();
            FormDataLoader.LoadDataToComboBox("Directions", "direction_name", comboBoxDirection, null, "Все");
            FormDataLoader.LoadDataToComboBox("Groups", "group_name", comboBoxGroup);
            id = -1;
            labelID.Visible = false;
        }
        public void InitForm(string id, string last_name, string first_name, string middle_name, DateTime birth_date, string email, string phone, string group, string direction, Image photo = null)
        {

            this.id = Convert.ToInt32(id);
            richTextBoxLastName.Text = last_name;
            richTextBoxFirstName.Text = first_name;
            richTextBoxMiddleName.Text = middle_name;
            dateTimePickerBirthDate.Value = birth_date;
            richTextBoxEmail.Text = email;
            richTextBoxPhone.Text = phone;
            comboBoxGroup.SelectedIndex = comboBoxGroup.FindStringExact(group);
            comboBoxDirection.SelectedIndex = comboBoxDirection.FindStringExact(direction);
            pictureBoxPhoto.Image = photo;
            labelID.Text = $"ID студента в базе: {id}";
            labelID.Visible = true;
            //LockFields();
        }
        private void LockFields()
        {
            richTextBoxLastName.Enabled = false;
            richTextBoxFirstName.Enabled = false;
            richTextBoxMiddleName.Enabled = false;
            richTextBoxEmail.Enabled = false;
            richTextBoxPhone.Enabled = false;
            dateTimePickerBirthDate.Enabled = false;
            comboBoxGroup.Enabled = false;
            comboBoxDirection.Enabled = false;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            MemoryStream ms = new MemoryStream();
            pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);
            if (id < 0)
            {
                connector.InsertDataToBase("Students",
                    "last_name, first_name, middle_name, birth_date, email, phone, photo, [group]",
                    $"'{richTextBoxLastName.Text}', '{richTextBoxFirstName.Text}', '{richTextBoxMiddleName.Text}', " +
                    $"'{dateTimePickerBirthDate.Value.ToString("yyyy.MM.dd")}', '{richTextBoxEmail.Text}', '{richTextBoxPhone.Text}', " +
                    $"'{null}', {connector.GetIDByValue("Groups", "group_id,group_name", comboBoxGroup.SelectedItem.ToString())}");
                connector.UpdateImage("Students", "photo", ms.ToArray(), $"stud_id={connector.GetMaxValue("Students", "stud_id")}");
            }
            else
            {
                connector.UpdateDataInBase("Students",
                    "last_name, first_name, middle_name, birth_date, email, phone, photo, [group]",
                    $"'{richTextBoxLastName.Text}', '{richTextBoxFirstName.Text}', '{richTextBoxMiddleName.Text}', " +
                    $"'{dateTimePickerBirthDate.Value}', '{richTextBoxEmail.Text}', '{richTextBoxPhone.Text}', " +
                    $"'{pictureBoxPhoto.Image}', {connector.GetIDByValue("Groups", "group_id,group_name", comboBoxGroup.SelectedItem.ToString())}",
                    $"stud_id = {id}");
                connector.UpdateImage("Students", "photo", ms.ToArray(), $"stud_id={id}");
            }
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
