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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace todoTxt
{
	/// <summary>
	/// Add & Edit Form
	/// </summary>
	public partial class EditForm : Form
	{
		// Properties

		public bool addMode = false;
		public int lineNumber = 0;
		public MainForm mainForm;


		// Constructor

		public EditForm()
		{
			InitializeComponent();
		}


		// Events

		private void EditForm_Load(object sender, EventArgs e)
		{
			if (!addMode)
			{
				taskNameTextBox.Text = mainForm.todoTasks[lineNumber].Trim();

				string date = mainForm.todoDates[lineNumber];

				dueDateTimePicker.Value = (date == null) ? DateTime.Now : DateTime.Parse(date);

				if (mainForm.todoDone[lineNumber])
				{
					doneCheckBox.Checked = true;
				}

				if (!String.IsNullOrEmpty(mainForm.todoPriorities[lineNumber]))
				{
					string priority = mainForm.todoPriorities[lineNumber];

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
			}

			// Contexts
			contextComboBox.Items.Add("");

			foreach (var context in mainForm.todoContextsStack)
			{
				contextComboBox.Items.Add(context);

				if ((!addMode) && (mainForm.todoContexts[lineNumber] == context))
				{
					contextComboBox.SelectedIndex = contextComboBox.Items.Count - 1;
				}
			}

			// Projects
			projectComboBox.Items.Add("");
			
			foreach (var project in mainForm.todoProjectsStack)
			{
				projectComboBox.Items.Add(project);

				if ((!addMode) && (mainForm.todoProjects[lineNumber] == project))
				{
					projectComboBox.SelectedIndex = projectComboBox.Items.Count - 1;
				}
			}

		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// Preparing the line to write.
			string lineToWrite = String.Empty;

			// If the task is done.
			if (doneCheckBox.Checked)
			{
				lineToWrite = "x ";
			}

			// Due Date
			lineToWrite = lineToWrite + dueDateTimePicker.Text + " ";

			// Priority
			string priority = String.Empty;

			if (priorityComboBox.SelectedIndex == 0)
			{
				priority = "(A)";
			}
			else if (priorityComboBox.SelectedIndex == 1)
			{
				priority = "(B)";
			}
			else if (priorityComboBox.SelectedIndex == 2)
			{
				priority = "(C)";
			}
			else if (priorityComboBox.SelectedIndex == 3)
			{
				priority = "(D)";
			}
			else if (priorityComboBox.SelectedIndex == 4)
			{
				priority = "(E)";
			}

			if (priority.Length > 0)
			{
				lineToWrite = lineToWrite + priority + " ";
			}

			// Task
			lineToWrite = lineToWrite + taskNameTextBox.Text + " ";

			// Context
			lineToWrite = lineToWrite + contextComboBox.Text + " ";

			// Project
			lineToWrite = lineToWrite + projectComboBox.Text + " ";

			// Writing the line.
			if (lineNumber > mainForm.todoContentLines.Length)
			{
				// Not being able to modify the size of a fixed array SUCKS.
				string[] newTodoContentLines = new string[lineNumber];

				for (int i = 0; i < mainForm.todoContentLines.Length; i++)
				{
					newTodoContentLines[i] = mainForm.todoContentLines[i];
				}

				newTodoContentLines[lineNumber -1] = lineToWrite;

				mainForm.todoContentLines = newTodoContentLines;
			}
			else
			{
				mainForm.todoContentLines[lineNumber] = lineToWrite;
			}

			mainForm.Save();

			this.Close();
		}

		private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			mainForm.OpenTodoTxt();
		}
	}
}