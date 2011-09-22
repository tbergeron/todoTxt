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

namespace todoTxt
{
	public partial class MainForm : Form
	{
		// Properties

		// Text file path, content & data
		public string todoTxtPath;
		public string[] todoContentLines;
		public string[] todoDates;
		public string[] todoPriorities;
		public string[] todoTasks;
		public bool[] todoDone;

		// Regexes
		// @\w*|\+\w*|[\n|\r]x\s|
		public Regex doneRegex = new Regex(@"^x\s");
		public Regex priorityRegex = new Regex(@"\([ABCDE]{1}\)");
		public Regex dateRegex = new Regex(@"[0-9]{4}-[0-9]{2}-[0-9]{2}");

		// Priorities colors
		// TODO : Change colors by icons.
		public Color priorityATextColor = Color.Red;
		public Color priorityBTextColor = Color.OrangeRed;
		public Color priorityCTextColor = Color.Yellow;
		public Color priorityDTextColor = Color.YellowGreen;
		public Color priorityETextColor = Color.Green;

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
			TextWriter writer = new StreamWriter(todoTxtPath);
			
			foreach (string line in todoContentLines)
			{
				writer.WriteLine(line);
			}

			writer.Close();
		}

		private void addTaskToolStripButton_Click(object sender, EventArgs e)
		{
			EditForm addForm = new EditForm();

			addForm.addMode = true;

			addForm.Show();
		}

		
		// Methods
		public void OpenTodoTxt()
		{
			todoContentLines = File.ReadAllLines(todoTxtPath);

			todoPriorities = new string[todoContentLines.Length];
			todoDates = new string[todoContentLines.Length];
			todoTasks = new string[todoContentLines.Length];
			todoDone = new bool[todoContentLines.Length];

			string date = String.Empty;
			string priority = String.Empty;
			string task = String.Empty;
			bool done = false;

			int lineNumber = 0;
			foreach (string line in todoContentLines)
			{
				date = "";
				priority = "";
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
					task = task.Replace(priority + " ", "");
				}

				if (dateRegex.Match(line).Success)
				{
					date = dateRegex.Match(line).Value;
					todoDates[lineNumber] = date;
					task = task.Replace(date + " ", "");
				}

				var newRow = listView.Items.Add("");
				newRow.Checked = done;
				newRow.UseItemStyleForSubItems = false;

				newRow.SubItems.Add(lineNumber.ToString());
				
				if (priority.Contains("A"))
				{
					newRow.ImageIndex = 0;
				}
				else if (priority.Contains("B"))
				{
					newRow.ImageIndex = 1;
				}
				else if (priority.Contains("C"))
				{
					newRow.ImageIndex = 2;
				}
				else if (priority.Contains("D"))
				{
					newRow.ImageIndex = 3;
				}
				else if (priority.Contains("E"))
				{
					newRow.ImageIndex = 4;
				}
				
				newRow.SubItems.Add(task);
				newRow.SubItems.Add(date);

				lineNumber++;
			}
		}

	}
}
