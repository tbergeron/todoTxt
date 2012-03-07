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

using System;
using System.IO;
using System.Windows.Forms;
using todoTxt.Classes;

namespace todoTxt
{
	/// <summary>
	/// Main Form
	/// </summary>
	public partial class MainForm : Form
	{
		#region Properties & Variables

		/// <summary>
		/// Task Collection
		/// </summary>
		public TaskCollection oTaskCollection = new TaskCollection();

		/// <summary>
		/// Todo.txt File Path
		/// </summary>
		public string todoTxtPath;

		#endregion

		#region Constuctor & Events

		/// <summary>
		/// MainForm Constructor
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Load Event
		/// </summary>
		private void MainForm_Load(object sender, EventArgs e)
		{
			todoTxtPath = Properties.Settings.Default.todoTxtRecentPath;

			if (File.Exists(todoTxtPath))
			{
				oTaskCollection.ParseTextFile(todoTxtPath);

				this.objectListView.SetObjects(oTaskCollection.Items);

				this.Text = "todoTxt - " + Path.GetFileName(todoTxtPath);
			}
		}

		/// <summary>
		/// Open button click event.
		/// </summary>
		private void openButton_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();

			todoTxtPath = openFileDialog.FileName;

			Properties.Settings.Default.todoTxtRecentPath = todoTxtPath;
			Properties.Settings.Default.Save();

			oTaskCollection.ParseTextFile(todoTxtPath);

			this.objectListView.SetObjects(oTaskCollection.Items);

			this.Text = "todoTxt - " + Path.GetFileName(todoTxtPath);
		}

		/// <summary>
		/// Add task click event.
		/// </summary>
		private void addTaskToolStripButton_Click(object sender, EventArgs e)
		{
			EditForm addForm = new EditForm();

			addForm.mainForm = this;
			addForm.addMode = true;
			addForm.lineNumber = oTaskCollection.GetLastLineNumber() +1;

			addForm.Show();
		}

		/// <summary>
		/// Delete task click event.
		/// </summary>
		private void deleteToolStripButton_Click(object sender, EventArgs e)
		{
			Task oSelectedTask = (Task)objectListView.SelectedItem.RowObject;

			if (MessageBox.Show("Are you sure to delete \"" + oSelectedTask.Name.Trim() + "\" ?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    // Setting the selected line to null so it gets skipped while saving.
				oTaskCollection.Items.Remove(oSelectedTask);
				this.objectListView.RemoveObject(oSelectedTask);
				this.SaveCollection();
			}

			this.RefreshObjectListView();
		}

		/// <summary>
		/// ObjectListView double click event.
		/// </summary>
		private void objectListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			EditForm editForm = new EditForm();

			editForm.mainForm = this;
			editForm.currentTask = (Task)objectListView.SelectedItem.RowObject;

			editForm.Show();
		}

		/// <summary>
		/// About dialog click event.
		/// </summary>
		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.Show();
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Refreshes the ObjectListView.
		/// </summary>
		public void RefreshObjectListView()
		{
			this.objectListView.RefreshObjects(this.oTaskCollection.Items);
		}

		/// <summary>
		/// Adds a new object to the ObjectListView.
		/// </summary>
		/// <param name="p_oNewTask">Task</param>
		public void AddObjectToObjectListView(Task p_oNewTask)
		{
			this.oTaskCollection.Items.Add(p_oNewTask);
			this.objectListView.AddObject(p_oNewTask);
		}

		/// <summary>
		/// Tells the collection to save itself.
		/// </summary>
		public void SaveCollection()
		{
			this.oTaskCollection.Save(todoTxtPath);
		}

		#endregion
	}
}