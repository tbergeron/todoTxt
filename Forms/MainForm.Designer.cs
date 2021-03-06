﻿namespace todoTxt
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.priorityImageList = new System.Windows.Forms.ImageList(this.components);
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.doneColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.priorityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.taskColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.projectColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "todo.txt";
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
            // objectListView
            // 
            this.objectListView.AllColumns.Add(this.doneColumn);
            this.objectListView.AllColumns.Add(this.priorityColumn);
            this.objectListView.AllColumns.Add(this.taskColumn);
            this.objectListView.AllColumns.Add(this.contextColumn);
            this.objectListView.AllColumns.Add(this.projectColumn);
            this.objectListView.AllColumns.Add(this.dateColumn);
            this.objectListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView.CheckBoxes = true;
            this.objectListView.CheckedAspectName = "IsDone";
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.doneColumn,
            this.priorityColumn,
            this.taskColumn,
            this.contextColumn,
            this.projectColumn,
            this.dateColumn});
            this.objectListView.FullRowSelect = true;
            this.objectListView.Location = new System.Drawing.Point(12, 28);
            this.objectListView.Name = "objectListView";
            this.objectListView.ShowImagesOnSubItems = true;
            this.objectListView.Size = new System.Drawing.Size(736, 352);
            this.objectListView.SmallImageList = this.priorityImageList;
            this.objectListView.TabIndex = 6;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.UseSubItemCheckBoxes = true;
            this.objectListView.View = System.Windows.Forms.View.Details;
            this.objectListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListView_MouseDoubleClick);
            // 
            // doneColumn
            // 
            this.doneColumn.AspectName = "IsDoneString";
            this.doneColumn.CheckBoxes = true;
            this.doneColumn.Text = "";
            this.doneColumn.Width = 24;
            // 
            // priorityColumn
            // 
            this.priorityColumn.AspectName = "PriorityString";
            this.priorityColumn.Text = "Priority";
            this.priorityColumn.Width = 99;
            // 
            // taskColumn
            // 
            this.taskColumn.AspectName = "Name";
            this.taskColumn.FillsFreeSpace = true;
            this.taskColumn.Groupable = false;
            this.taskColumn.Text = "Task";
            this.taskColumn.Width = 306;
            // 
            // contextColumn
            // 
            this.contextColumn.AspectName = "Context";
            this.contextColumn.Text = "Context";
            this.contextColumn.Width = 95;
            // 
            // projectColumn
            // 
            this.projectColumn.AspectName = "Project";
            this.projectColumn.Text = "Project";
            this.projectColumn.Width = 108;
            // 
            // dateColumn
            // 
            this.dateColumn.AspectName = "DueDate";
            this.dateColumn.Text = "Due Date";
            this.dateColumn.Width = 100;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addTaskToolStripButton
            // 
            this.addTaskToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addTaskToolStripButton.Image")));
            this.addTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTaskToolStripButton.Name = "addTaskToolStripButton";
            this.addTaskToolStripButton.Size = new System.Drawing.Size(107, 22);
            this.addTaskToolStripButton.Text = "Add a new task";
            this.addTaskToolStripButton.Click += new System.EventHandler(this.addTaskToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(130, 22);
            this.deleteToolStripButton.Text = "Delete selected task";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(23, 22);
            this.aboutButton.Text = "About todoTxt";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.toolStripSeparator1,
            this.addTaskToolStripButton,
            this.deleteToolStripButton,
            this.aboutButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(760, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 392);
            this.Controls.Add(this.objectListView);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "todoTxt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ImageList priorityImageList;
		private BrightIdeasSoftware.ObjectListView objectListView;
		private BrightIdeasSoftware.OLVColumn priorityColumn;
		private BrightIdeasSoftware.OLVColumn taskColumn;
		private BrightIdeasSoftware.OLVColumn contextColumn;
		private BrightIdeasSoftware.OLVColumn projectColumn;
		private BrightIdeasSoftware.OLVColumn dateColumn;
		private BrightIdeasSoftware.OLVColumn doneColumn;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton addTaskToolStripButton;
		private System.Windows.Forms.ToolStripButton deleteToolStripButton;
		private System.Windows.Forms.ToolStripButton aboutButton;
		private System.Windows.Forms.ToolStrip toolStrip;
    }
}

