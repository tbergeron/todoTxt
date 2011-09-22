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
			this.label6 = new System.Windows.Forms.Label();
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
			this.label2.Location = new System.Drawing.Point(11, 53);
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
			this.priorityComboBox.Location = new System.Drawing.Point(14, 69);
			this.priorityComboBox.Name = "priorityComboBox";
			this.priorityComboBox.Size = new System.Drawing.Size(185, 21);
			this.priorityComboBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(204, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Due date:";
			// 
			// dueDateTimePicker
			// 
			this.dueDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dueDateTimePicker.Location = new System.Drawing.Point(207, 69);
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
			this.contextComboBox.Location = new System.Drawing.Point(14, 114);
			this.contextComboBox.Name = "contextComboBox";
			this.contextComboBox.Size = new System.Drawing.Size(185, 21);
			this.contextComboBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Context:";
			// 
			// projectComboBox
			// 
			this.projectComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.projectComboBox.FormattingEnabled = true;
			this.projectComboBox.Location = new System.Drawing.Point(207, 114);
			this.projectComboBox.Name = "projectComboBox";
			this.projectComboBox.Size = new System.Drawing.Size(185, 21);
			this.projectComboBox.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(204, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Project:";
			// 
			// doneCheckBox
			// 
			this.doneCheckBox.AutoSize = true;
			this.doneCheckBox.Location = new System.Drawing.Point(378, 9);
			this.doneCheckBox.Name = "doneCheckBox";
			this.doneCheckBox.Size = new System.Drawing.Size(15, 14);
			this.doneCheckBox.TabIndex = 11;
			this.doneCheckBox.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(302, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Task finished:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 147);
			this.Controls.Add(this.label6);
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
			this.Name = "EditForm";
			this.Text = "Add a task";
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
		private System.Windows.Forms.Label label6;
	}
}