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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;

namespace todoTxt
{
	/// <summary>
	/// Main Form
	/// </summary>
	public partial class MainForm : Form
	{
		// Properties

		// Text file path, content & data
		public string todoTxtPath;
		public string[] todoContentLines;
		public string[] todoDates;
		public string[] todoPriorities;
		public string[] todoTasks;
		public string[] todoContexts;
		public string[] todoProjects;
		public bool[] todoDone;

		public Stack<string> todoContextsStack = new Stack<string>();
		public Stack<string> todoProjectsStack = new Stack<string>();

		// Regexes
		private Regex doneRegex = new Regex(@"^x\s");
		private Regex priorityRegex = new Regex(@"\([ABCDE]{1}\)");
		private Regex dateRegex = new Regex(@"[0-9]{4}-[0-9]{2}-[0-9]{2}");
		private Regex contextRegex = new Regex(@"@\w*");
		private Regex projectRegex = new Regex(@"\+\w*");

		
		// Constuctor
		
		public MainForm()
		{
			InitializeComponent();
		}

		
		// Events
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			todoTxtPath = Properties.Settings.Default.todoTxtRecentPath;

			if (File.Exists(todoTxtPath))
			{
				OpenTodoTxt();
			}

		}

		private void openButton_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();

			todoTxtPath = openFileDialog.FileName;

			Properties.Settings.Default.todoTxtRecentPath = todoTxtPath;
			Properties.Settings.Default.Save();

			OpenTodoTxt();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void addTaskToolStripButton_Click(object sender, EventArgs e)
		{
			EditForm addForm = new EditForm();

            addForm.mainForm = this;
			addForm.addMode = true;
			addForm.lineNumber = todoContentLines.Length +1;

			addForm.Show();
		}

		private void deleteToolStripButton_Click(object sender, EventArgs e)
		{
			int lineNumber = listView.SelectedItems[0].Index;

			if (MessageBox.Show("Are you sure to delete \"" + todoTasks[lineNumber].Trim() + "\" ?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				// Setting the selected line to null so it gets skipped while saving.
				todoContentLines[lineNumber] = null;
				Save();

				OpenTodoTxt();
			}

		}

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			// Preventing listView's checkboxes to get checked/unchecked on double clicks.
			//listView.SelectedItems[0].Checked = (listView.SelectedItems[0].Checked) ? false : true;

            EditForm editForm = new EditForm();

            editForm.mainForm = this;
            editForm.lineNumber = listView.SelectedItems[0].Index;

            editForm.Show();
        }

		private void listView_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.Index % 2 == 1)
			{
				e.NewValue = e.CurrentValue;
			}
		}
		

		// Methods
		
		public void OpenTodoTxt()
		{
			listView.Items.Clear();

			todoContentLines = File.ReadAllLines(todoTxtPath);

			todoPriorities = new string[todoContentLines.Length];
			todoDates = new string[todoContentLines.Length];
			todoTasks = new string[todoContentLines.Length];
			todoContexts = new string[todoContentLines.Length];
			todoProjects = new string[todoContentLines.Length];
			todoDone = new bool[todoContentLines.Length];

			string date = String.Empty;
			string priority = String.Empty;
			string task = String.Empty;
			string context = String.Empty;
			string project = String.Empty;
			bool done = false;

			int lineNumber = 0;
			foreach (string line in todoContentLines)
			{
				date = "";
				priority = "";
				context = "";
				project = "";
				task = line;
				done = false;

				if (doneRegex.Match(line).Success)
				{
					done = true;
					todoDone[lineNumber] = true;
					task = line.Replace("x ", "");
				}

				if (priorityRegex.Match(line).Success)
				{
					priority = priorityRegex.Match(line).Value;
					todoPriorities[lineNumber] = priority.Replace("(", "").Replace(")", "");
					task = task.Replace(priority + " ", "");
				}

				if (dateRegex.Match(line).Success)
				{
					date = dateRegex.Match(line).Value;
					todoDates[lineNumber] = date;
					task = task.Replace(date + " ", "");
				}


				if (contextRegex.Match(line).Success)
				{
					context = contextRegex.Match(line).Value;

					task = task.Replace(context, "");

					todoContexts[lineNumber] = context;

					if (!todoContextsStack.Contains(context))
					{
						todoContextsStack.Push(contextRegex.Match(line).Value);
					}
				}

				if (projectRegex.Match(line).Success)
				{
					project = projectRegex.Match(line).Value;

					task = task.Replace(project, "");

					todoProjects[lineNumber] = project;

					if (!todoProjectsStack.Contains(project))
					{
						todoProjectsStack.Push(projectRegex.Match(line).Value);
					}
				}

				var newRow = listView.Items.Add("");
				newRow.Checked = done;
				//newRow.UseItemStyleForSubItems = false;

				newRow.SubItems.Add(lineNumber.ToString());
				
				if (priority.Contains("A"))
				{
					if (!done)
					{
						newRow.BackColor = Color.Red;
						newRow.ForeColor = Color.White;
					}
					newRow.ImageIndex = 0;
				}
				else if (priority.Contains("B"))
				{
					if (!done)
					{
						newRow.BackColor = Color.Orange;
						newRow.ImageIndex = 1;
					}
				}
				else if (priority.Contains("C"))
				{
					if (!done)
					{
						newRow.BackColor = Color.Yellow;
						newRow.ImageIndex = 2;
					}
				}
				else if (priority.Contains("D"))
				{
					if (!done)
					{
						newRow.BackColor = Color.YellowGreen;
						newRow.ImageIndex = 3;
					}
				}
				else if (priority.Contains("E"))
				{
					newRow.ImageIndex = 4;
				}

                todoTasks[lineNumber] = task;

				newRow.SubItems.Add(task);
				newRow.SubItems.Add(date);
				newRow.SubItems.Add(context);
				newRow.SubItems.Add(project);

				lineNumber++;
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.Show();
		}


		// Methods

		/// <summary>
		/// Saves file content on the disk.
		/// </summary>
		public void Save()
		{
			using (TextWriter writer = new StreamWriter(todoTxtPath))
			{
				foreach (string line in todoContentLines)
				{
					if (line != null)
					{
						writer.WriteLine(line);
					}
				}
			}
		}

	}
}
