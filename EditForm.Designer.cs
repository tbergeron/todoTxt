/*
 * todoTxt
 * adding power to your todo.txt file!
 * 
 * Copyright (C) 2011 Tommy Bergeron @ Brainpad 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see http://www.gnu.org/licenses/.
 */

namespace todoTxt
{
	partial class EditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
			this.label1 = new System.Windows.Forms.Label();
			this.taskNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.priorityComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.contextComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.projectComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.doneCheckBox = new System.Windows.Forms.CheckBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Task name:";
			// 
			// taskNameTextBox
			// 
			this.taskNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.taskNameTextBox.Location = new System.Drawing.Point(14, 25);
			this.taskNameTextBox.Name = "taskNameTextBox";
			this.taskNameTextBox.Size = new System.Drawing.Size(378, 20);
			this.taskNameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Priority";
			// 
			// priorityComboBox
			// 
			this.priorityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.priorityComboBox.FormattingEnabled = true;
			this.priorityComboBox.Items.AddRange(new object[] {
            "Critical",
            "High",
            "Medium",
            "Low",
            "Non Important"});
			this.priorityComboBox.Location = new System.Drawing.Point(14, 84);
			this.priorityComboBox.Name = "priorityComboBox";
			this.priorityComboBox.Size = new System.Drawing.Size(185, 21);
			this.priorityComboBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(204, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Due date:";
			// 
			// dueDateTimePicker
			// 
			this.dueDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dueDateTimePicker.CustomFormat = "yyyy-MM-dd";
			this.dueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dueDateTimePicker.Location = new System.Drawing.Point(207, 84);
			this.dueDateTimePicker.Name = "dueDateTimePicker";
			this.dueDateTimePicker.Size = new System.Drawing.Size(185, 20);
			this.dueDateTimePicker.TabIndex = 5;
			// 
			// contextComboBox
			// 
			this.contextComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contextComboBox.FormattingEnabled = true;
			this.contextComboBox.Location = new System.Drawing.Point(14, 129);
			this.contextComboBox.Name = "contextComboBox";
			this.contextComboBox.Size = new System.Drawing.Size(185, 21);
			this.contextComboBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Context:";
			// 
			// projectComboBox
			// 
			this.projectComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.projectComboBox.FormattingEnabled = true;
			this.projectComboBox.Location = new System.Drawing.Point(207, 129);
			this.projectComboBox.Name = "projectComboBox";
			this.projectComboBox.Size = new System.Drawing.Size(185, 21);
			this.projectComboBox.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(204, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Project:";
			// 
			// doneCheckBox
			// 
			this.doneCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.doneCheckBox.AutoSize = true;
			this.doneCheckBox.Location = new System.Drawing.Point(14, 180);
			this.doneCheckBox.Name = "doneCheckBox";
			this.doneCheckBox.Size = new System.Drawing.Size(99, 17);
			this.doneCheckBox.TabIndex = 11;
			this.doneCheckBox.Text = "Task is finished";
			this.doneCheckBox.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(317, 175);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 13;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Location = new System.Drawing.Point(-13, 161);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(541, 5);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Location = new System.Drawing.Point(-19, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(541, 5);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 207);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.doneCheckBox);
			this.Controls.Add(this.projectComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.contextComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dueDateTimePicker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.priorityComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.taskNameTextBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditForm";
			this.Text = "Edit a task";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
			this.Load += new System.EventHandler(this.EditForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox taskNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox priorityComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dueDateTimePicker;
		private System.Windows.Forms.ComboBox contextComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox projectComboBox;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox doneCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
	}
}