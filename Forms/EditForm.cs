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
using System.Windows.Forms;
using todoTxt.Classes;

namespace todoTxt
{
	/// <summary>
	/// Add & Edit Form
	/// </summary>
	public partial class EditForm : Form
	{
		#region Properties
		
		public bool addMode = false;
		public int lineNumber = 0;
		public MainForm mainForm;
		public Task currentTask;
		
		#endregion

		#region Constructor & Events
		
		/// <summary>
		/// EditForm's Constructor
		/// </summary>
		public EditForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// EditForm's Load event.
		/// </summary>
		private void EditForm_Load(object sender, EventArgs e)
		{
			if (!addMode)
			{
				taskNameTextBox.Text = currentTask.Name.Trim();

				string date = currentTask.DueDate;

				dueDateTimePicker.Value = (date == null) ? DateTime.Now : DateTime.Parse(date);

				if (currentTask.IsDone)
				{
					doneCheckBox.Checked = true;
				}

				if (!String.IsNullOrEmpty(currentTask.Priority))
				{
					string priority = currentTask.Priority;

					if (priority == "A")
					{
						priorityComboBox.SelectedIndex = 0;
					}
					else if (priority == "B")
					{
						priorityComboBox.SelectedIndex = 1;
					}
					else if (priority == "C")
					{
						priorityComboBox.SelectedIndex = 2;
					}
					else if (priority == "D")
					{
						priorityComboBox.SelectedIndex = 3;
					}
					else if (priority == "E")
					{
						priorityComboBox.SelectedIndex = 4;
					}
				}
			}
			else
			{
				Text = "Add a new task";
				currentTask = new Task();
			}

			// Contexts
			contextComboBox.Items.Add("");

			foreach (var context in mainForm.oTaskCollection.GetContexts())
			{
				contextComboBox.Items.Add(context);

				if ((!addMode) && (currentTask.Context == context))
				{
					contextComboBox.SelectedIndex = contextComboBox.Items.Count - 1;
				}
			}

			// Projects
			projectComboBox.Items.Add("");

			foreach (var project in mainForm.oTaskCollection.GetProjects())
			{
				projectComboBox.Items.Add(project);

				if ((!addMode) && (currentTask.Project == project))
				{
					projectComboBox.SelectedIndex = projectComboBox.Items.Count - 1;
				}
			}

		}

		/// <summary>
		/// Save click event.
		/// </summary>
		private void saveButton_Click(object sender, EventArgs e)
		{
			if (addMode)
			{
				currentTask.LineNumber = lineNumber;
			}

			// If the task is done.
			currentTask.IsDone = (doneCheckBox.Checked) ? true : false;

			// Due Date
			currentTask.DueDate = dueDateTimePicker.Text;

			// Priority
			string priority = String.Empty;

			if (priorityComboBox.SelectedIndex == 0)
			{
				priority = "A";
			}
			else if (priorityComboBox.SelectedIndex == 1)
			{
				priority = "B";
			}
			else if (priorityComboBox.SelectedIndex == 2)
			{
				priority = "C";
			}
			else if (priorityComboBox.SelectedIndex == 3)
			{
				priority = "D";
			}
			else if (priorityComboBox.SelectedIndex == 4)
			{
				priority = "E";
			}

			if (priority.Length > 0)
			{
				currentTask.Priority = priority;
			}

			// Task
			currentTask.Name = taskNameTextBox.Text;

			// Context
			currentTask.Context = contextComboBox.Text.Replace("None", "");

			// Project
			currentTask.Project = projectComboBox.Text.Replace("None", "");

			if (addMode)
			{
				this.mainForm.AddObjectToObjectListView(currentTask);
			}

			// Refresh the listview.
			this.mainForm.RefreshObjectListView();
			this.mainForm.SaveCollection();
			this.Close();
		}

		#endregion
	}
}