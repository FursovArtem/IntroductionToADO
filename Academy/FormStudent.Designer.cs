namespace Academy
{
	partial class FormStudent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.richTextBoxLastName = new System.Windows.Forms.RichTextBox();
			this.richTextBoxFirstName = new System.Windows.Forms.RichTextBox();
			this.richTextBoxMiddleName = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.labelDirection = new System.Windows.Forms.Label();
			this.labelGroup = new System.Windows.Forms.Label();
			this.comboBoxDirection = new System.Windows.Forms.ComboBox();
			this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
			this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
			this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonBrows = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelFirstName
			// 
			this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(103, 38);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(32, 13);
			this.labelFirstName.TabIndex = 1;
			this.labelFirstName.Text = "Имя:";
			// 
			// labelLastName
			// 
			this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(76, 8);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(59, 13);
			this.labelLastName.TabIndex = 0;
			this.labelLastName.Text = "Фамилия:";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Location = new System.Drawing.Point(78, 68);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
			this.labelMiddleName.TabIndex = 2;
			this.labelMiddleName.Text = "Отчество:";
			// 
			// richTextBoxLastName
			// 
			this.richTextBoxLastName.Location = new System.Drawing.Point(141, 3);
			this.richTextBoxLastName.MaxLength = 256;
			this.richTextBoxLastName.Multiline = false;
			this.richTextBoxLastName.Name = "richTextBoxLastName";
			this.richTextBoxLastName.Size = new System.Drawing.Size(200, 22);
			this.richTextBoxLastName.TabIndex = 3;
			this.richTextBoxLastName.Text = "";
			// 
			// richTextBoxFirstName
			// 
			this.richTextBoxFirstName.Location = new System.Drawing.Point(141, 33);
			this.richTextBoxFirstName.MaxLength = 256;
			this.richTextBoxFirstName.Multiline = false;
			this.richTextBoxFirstName.Name = "richTextBoxFirstName";
			this.richTextBoxFirstName.Size = new System.Drawing.Size(200, 22);
			this.richTextBoxFirstName.TabIndex = 4;
			this.richTextBoxFirstName.Text = "";
			// 
			// richTextBoxMiddleName
			// 
			this.richTextBoxMiddleName.Location = new System.Drawing.Point(141, 63);
			this.richTextBoxMiddleName.MaxLength = 256;
			this.richTextBoxMiddleName.Multiline = false;
			this.richTextBoxMiddleName.Name = "richTextBoxMiddleName";
			this.richTextBoxMiddleName.Size = new System.Drawing.Size(200, 22);
			this.richTextBoxMiddleName.TabIndex = 5;
			this.richTextBoxMiddleName.Text = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Дата рождения:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(141, 93);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelLastName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.richTextBoxLastName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.richTextBoxMiddleName, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.richTextBoxFirstName, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelMiddleName, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 120);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel2.Controls.Add(this.comboBoxGroup, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.comboBoxDirection, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.labelGroup, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.labelDirection, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 226);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 60);
			this.tableLayoutPanel2.TabIndex = 9;
			// 
			// labelDirection
			// 
			this.labelDirection.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelDirection.AutoSize = true;
			this.labelDirection.Location = new System.Drawing.Point(8, 8);
			this.labelDirection.Name = "labelDirection";
			this.labelDirection.Size = new System.Drawing.Size(127, 13);
			this.labelDirection.TabIndex = 10;
			this.labelDirection.Text = "Направление обучения:";
			// 
			// labelGroup
			// 
			this.labelGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(90, 38);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(45, 13);
			this.labelGroup.TabIndex = 10;
			this.labelGroup.Text = "Группа:";
			// 
			// comboBoxDirection
			// 
			this.comboBoxDirection.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxDirection.FormattingEnabled = true;
			this.comboBoxDirection.Location = new System.Drawing.Point(141, 4);
			this.comboBoxDirection.Name = "comboBoxDirection";
			this.comboBoxDirection.Size = new System.Drawing.Size(200, 21);
			this.comboBoxDirection.TabIndex = 10;
			// 
			// comboBoxGroup
			// 
			this.comboBoxGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxGroup.FormattingEnabled = true;
			this.comboBoxGroup.Location = new System.Drawing.Point(141, 34);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new System.Drawing.Size(200, 21);
			this.comboBoxGroup.TabIndex = 10;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel3.Controls.Add(this.richTextBoxPhone, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.richTextBoxEmail, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.labelPhone, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.labelEmail, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 148);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(347, 60);
			this.tableLayoutPanel3.TabIndex = 10;
			// 
			// labelEmail
			// 
			this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(97, 8);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(38, 13);
			this.labelEmail.TabIndex = 11;
			this.labelEmail.Text = "E-mail:";
			// 
			// labelPhone
			// 
			this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(80, 38);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(55, 13);
			this.labelPhone.TabIndex = 11;
			this.labelPhone.Text = "Телефон:";
			// 
			// richTextBoxEmail
			// 
			this.richTextBoxEmail.Location = new System.Drawing.Point(141, 3);
			this.richTextBoxEmail.MaxLength = 256;
			this.richTextBoxEmail.Multiline = false;
			this.richTextBoxEmail.Name = "richTextBoxEmail";
			this.richTextBoxEmail.Size = new System.Drawing.Size(200, 22);
			this.richTextBoxEmail.TabIndex = 11;
			this.richTextBoxEmail.Text = "";
			// 
			// richTextBoxPhone
			// 
			this.richTextBoxPhone.Location = new System.Drawing.Point(141, 33);
			this.richTextBoxPhone.MaxLength = 17;
			this.richTextBoxPhone.Multiline = false;
			this.richTextBoxPhone.Name = "richTextBoxPhone";
			this.richTextBoxPhone.Size = new System.Drawing.Size(200, 22);
			this.richTextBoxPhone.TabIndex = 11;
			this.richTextBoxPhone.Text = "";
			this.richTextBoxPhone.WordWrap = false;
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.BackgroundImage")));
			this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPhoto.Location = new System.Drawing.Point(365, 12);
			this.pictureBoxPhoto.Name = "pictureBoxPhoto";
			this.pictureBoxPhoto.Size = new System.Drawing.Size(156, 196);
			this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxPhoto.TabIndex = 11;
			this.pictureBoxPhoto.TabStop = false;
			// 
			// buttonSave
			// 
			this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSave.Location = new System.Drawing.Point(365, 264);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(446, 264);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonBrows
			// 
			this.buttonBrows.Location = new System.Drawing.Point(446, 214);
			this.buttonBrows.Name = "buttonBrows";
			this.buttonBrows.Size = new System.Drawing.Size(75, 23);
			this.buttonBrows.TabIndex = 14;
			this.buttonBrows.Text = "Обзор";
			this.buttonBrows.UseVisualStyleBackColor = true;
			// 
			// FormStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 298);
			this.Controls.Add(this.buttonBrows);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.pictureBoxPhoto);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "FormStudent";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Студент";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.RichTextBox richTextBoxLastName;
		private System.Windows.Forms.RichTextBox richTextBoxFirstName;
		private System.Windows.Forms.RichTextBox richTextBoxMiddleName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ComboBox comboBoxGroup;
		private System.Windows.Forms.ComboBox comboBoxDirection;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.Label labelDirection;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.RichTextBox richTextBoxPhone;
		private System.Windows.Forms.RichTextBox richTextBoxEmail;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.PictureBox pictureBoxPhoto;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonBrows;
	}
}