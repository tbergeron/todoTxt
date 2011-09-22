namespace todoTxt
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.saveButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.upButton = new System.Windows.Forms.ToolStripButton();
			this.downButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.openTaskButton = new System.Windows.Forms.ToolStripButton();
			this.closeTaskButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.dateButton = new System.Windows.Forms.ToolStripButton();
			this.priorityButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.criticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nonImportantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.projectButton = new System.Windows.Forms.ToolStripButton();
			this.contextButton = new System.Windows.Forms.ToolStripButton();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.listView = new System.Windows.Forms.ListView();
			this.Done = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LineNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.priorityImageList = new System.Windows.Forms.ImageList(this.components);
			this.addTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.toolStripSeparator1,
            this.addTaskToolStripButton,
            this.toolStripSeparator5,
            this.upButton,
            this.downButton,
            this.toolStripSeparator2,
            this.openTaskButton,
            this.closeTaskButton,
            this.toolStripSeparator3,
            this.dateButton,
            this.priorityButton,
            this.toolStripSeparator4,
            this.projectButton,
            this.contextButton,
            this.aboutButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip.Size = new System.Drawing.Size(467, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip1";
			// 
			// openButton
			// 
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(23, 22);
			this.openButton.Text = "Open";
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
			this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(23, 22);
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// upButton
			// 
			this.upButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.upButton.Image = ((System.Drawing.Image)(resources.GetObject("upButton.Image")));
			this.upButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(23, 22);
			this.upButton.Text = "Move up";
			// 
			// downButton
			// 
			this.downButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.downButton.Image = ((System.Drawing.Image)(resources.GetObject("downButton.Image")));
			this.downButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(23, 22);
			this.downButton.Text = "Move down";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// openTaskButton
			// 
			this.openTaskButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("openTaskButton.Image")));
			this.openTaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openTaskButton.Name = "openTaskButton";
			this.openTaskButton.Size = new System.Drawing.Size(23, 22);
			this.openTaskButton.Text = "Reopen task";
			// 
			// closeTaskButton
			// 
			this.closeTaskButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.closeTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("closeTaskButton.Image")));
			this.closeTaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.closeTaskButton.Name = "closeTaskButton";
			this.closeTaskButton.Size = new System.Drawing.Size(23, 22);
			this.closeTaskButton.Text = "Close task";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// dateButton
			// 
			this.dateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.dateButton.Enabled = false;
			this.dateButton.Image = ((System.Drawing.Image)(resources.GetObject("dateButton.Image")));
			this.dateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.dateButton.Name = "dateButton";
			this.dateButton.Size = new System.Drawing.Size(23, 22);
			this.dateButton.Text = "Date";
			// 
			// priorityButton
			// 
			this.priorityButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.priorityButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criticalToolStripMenuItem,
            this.highToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.lowToolStripMenuItem,
            this.nonImportantToolStripMenuItem});
			this.priorityButton.Enabled = false;
			this.priorityButton.Image = ((System.Drawing.Image)(resources.GetObject("priorityButton.Image")));
			this.priorityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.priorityButton.Name = "priorityButton";
			this.priorityButton.Size = new System.Drawing.Size(29, 22);
			this.priorityButton.Text = "Priority";
			// 
			// criticalToolStripMenuItem
			// 
			this.criticalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("criticalToolStripMenuItem.Image")));
			this.criticalToolStripMenuItem.Name = "criticalToolStripMenuItem";
			this.criticalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.criticalToolStripMenuItem.Text = "Critical";
			// 
			// highToolStripMenuItem
			// 
			this.highToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("highToolStripMenuItem.Image")));
			this.highToolStripMenuItem.Name = "highToolStripMenuItem";
			this.highToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.highToolStripMenuItem.Text = "High";
			// 
			// mediumToolStripMenuItem
			// 
			this.mediumToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mediumToolStripMenuItem.Image")));
			this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
			this.mediumToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.mediumToolStripMenuItem.Text = "Medium";
			// 
			// lowToolStripMenuItem
			// 
			this.lowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lowToolStripMenuItem.Image")));
			this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
			this.lowToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.lowToolStripMenuItem.Text = "Low";
			// 
			// nonImportantToolStripMenuItem
			// 
			this.nonImportantToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nonImportantToolStripMenuItem.Image")));
			this.nonImportantToolStripMenuItem.Name = "nonImportantToolStripMenuItem";
			this.nonImportantToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.nonImportantToolStripMenuItem.Text = "Non Important";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// projectButton
			// 
			this.projectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.projectButton.Enabled = false;
			this.projectButton.Image = ((System.Drawing.Image)(resources.GetObject("projectButton.Image")));
			this.projectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.projectButton.Name = "projectButton";
			this.projectButton.Size = new System.Drawing.Size(23, 22);
			this.projectButton.Text = "Projects";
			// 
			// contextButton
			// 
			this.contextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.contextButton.Enabled = false;
			this.contextButton.Image = ((System.Drawing.Image)(resources.GetObject("contextButton.Image")));
			this.contextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.contextButton.Name = "contextButton";
			this.contextButton.Size = new System.Drawing.Size(23, 22);
			this.contextButton.Text = "Contexts";
			// 
			// aboutButton
			// 
			this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutButton.Enabled = false;
			this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
			this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(23, 22);
			this.aboutButton.Text = "About";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "todo.txt";
			// 
			// listView
			// 
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView.CheckBoxes = true;
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Done,
            this.LineNumber,
            this.TaskName,
            this.Date});
			this.listView.FullRowSelect = true;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(5, 28);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(458, 334);
			this.listView.SmallImageList = this.priorityImageList;
			this.listView.TabIndex = 5;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// Done
			// 
			this.Done.Text = "";
			this.Done.Width = 42;
			// 
			// LineNumber
			// 
			this.LineNumber.Text = "#";
			this.LineNumber.Width = 0;
			// 
			// TaskName
			// 
			this.TaskName.Text = "Task";
			this.TaskName.Width = 320;
			// 
			// Date
			// 
			this.Date.Text = "Date";
			this.Date.Width = 75;
			// 
			// priorityImageList
			// 
			this.priorityImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("priorityImageList.ImageStream")));
			this.priorityImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.priorityImageList.Images.SetKeyName(0, "bullet_red.png");
			this.priorityImageList.Images.SetKeyName(1, "bullet_orange.png");
			this.priorityImageList.Images.SetKeyName(2, "bullet_yellow.png");
			this.priorityImageList.Images.SetKeyName(3, "bullet_green.png");
			this.priorityImageList.Images.SetKeyName(4, "bullet_blue.png");
			// 
			// addTaskToolStripButton
			// 
			this.addTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addTaskToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addTaskToolStripButton.Image")));
			this.addTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addTaskToolStripButton.Name = "addTaskToolStripButton";
			this.addTaskToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.addTaskToolStripButton.Text = "toolStripButton1";
			this.addTaskToolStripButton.Click += new System.EventHandler(this.addTaskToolStripButton_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 367);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.toolStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "todoTxt";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton upButton;
		private System.Windows.Forms.ToolStripButton downButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton openTaskButton;
		private System.Windows.Forms.ToolStripButton closeTaskButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripDropDownButton priorityButton;
		private System.Windows.Forms.ToolStripMenuItem criticalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nonImportantToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton projectButton;
		private System.Windows.Forms.ToolStripButton contextButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton dateButton;
		private System.Windows.Forms.ToolStripButton aboutButton;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader LineNumber;
		private System.Windows.Forms.ColumnHeader TaskName;
		private System.Windows.Forms.ColumnHeader Date;
		private System.Windows.Forms.ColumnHeader Done;
		private System.Windows.Forms.ImageList priorityImageList;
		private System.Windows.Forms.ToolStripButton addTaskToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

    }
}

