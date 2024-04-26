namespace Academy
{
	partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGroupsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.comboBoxStudentsGroup = new System.Windows.Forms.ComboBox();
            this.labelStudentsGroup = new System.Windows.Forms.Label();
            this.comboBoxStudentsDirection = new System.Windows.Forms.ComboBox();
            this.labelStudentsDirection = new System.Windows.Forms.Label();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageSchedule);
            this.tabControl.Controls.Add(this.tabPageTeachers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.statusStrip);
            this.tabPageStudents.Controls.Add(this.buttonAddStudent);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroup);
            this.tabPageStudents.Controls.Add(this.labelStudentsGroup);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsDirection);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(792, 424);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStudentsCount,
            this.toolStripStatusLabelGroupsCount});
            this.statusStrip.Location = new System.Drawing.Point(3, 399);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(786, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelStudentsCount
            // 
            this.toolStripStatusLabelStudentsCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelStudentsCount.Name = "toolStripStatusLabelStudentsCount";
            this.toolStripStatusLabelStudentsCount.Size = new System.Drawing.Size(191, 17);
            this.toolStripStatusLabelStudentsCount.Text = "toolStripStatusLabelStudentsCount";
            // 
            // toolStripStatusLabelGroupsCount
            // 
            this.toolStripStatusLabelGroupsCount.Name = "toolStripStatusLabelGroupsCount";
            this.toolStripStatusLabelGroupsCount.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelGroupsCount.Text = "toolStripStatusLabel1";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(709, 11);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStudent.TabIndex = 5;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(772, 369);
            this.dataGridViewStudents.TabIndex = 4;
            this.dataGridViewStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellDoubleClick);
            // 
            // comboBoxStudentsGroup
            // 
            this.comboBoxStudentsGroup.FormattingEnabled = true;
            this.comboBoxStudentsGroup.Location = new System.Drawing.Point(61, 12);
            this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
            this.comboBoxStudentsGroup.Size = new System.Drawing.Size(174, 21);
            this.comboBoxStudentsGroup.TabIndex = 3;
            this.comboBoxStudentsGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsGroup_SelectedIndexChanged);
            // 
            // labelStudentsGroup
            // 
            this.labelStudentsGroup.AutoSize = true;
            this.labelStudentsGroup.Location = new System.Drawing.Point(9, 16);
            this.labelStudentsGroup.Name = "labelStudentsGroup";
            this.labelStudentsGroup.Size = new System.Drawing.Size(45, 13);
            this.labelStudentsGroup.TabIndex = 2;
            this.labelStudentsGroup.Text = "Группа:";
            // 
            // comboBoxStudentsDirection
            // 
            this.comboBoxStudentsDirection.FormattingEnabled = true;
            this.comboBoxStudentsDirection.Location = new System.Drawing.Point(374, 12);
            this.comboBoxStudentsDirection.Name = "comboBoxStudentsDirection";
            this.comboBoxStudentsDirection.Size = new System.Drawing.Size(283, 21);
            this.comboBoxStudentsDirection.TabIndex = 1;
            this.comboBoxStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirection_SelectedIndexChanged);
            // 
            // labelStudentsDirection
            // 
            this.labelStudentsDirection.AutoSize = true;
            this.labelStudentsDirection.Location = new System.Drawing.Point(241, 16);
            this.labelStudentsDirection.Name = "labelStudentsDirection";
            this.labelStudentsDirection.Size = new System.Drawing.Size(127, 13);
            this.labelStudentsDirection.TabIndex = 0;
            this.labelStudentsDirection.Text = "Направление обучения:";
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(792, 424);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Группы";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(792, 424);
            this.tabPageSchedule.TabIndex = 2;
            this.tabPageSchedule.Text = "Расписание";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(792, 424);
            this.tabPageTeachers.TabIndex = 3;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "AcademyPD_321";
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageSchedule;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
		private System.Windows.Forms.Label labelStudentsGroup;
		private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
		private System.Windows.Forms.Label labelStudentsDirection;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.Button buttonAddStudent;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStudentsCount;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGroupsCount;
	}
}

