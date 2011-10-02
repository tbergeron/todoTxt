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
                taskNameTextBox.Text = mainForm.todoTasks[lineNumber];

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

			// Contexts
			foreach (var context in mainForm.todoContextsStack)
			{
				contextComboBox.Items.Add(context);

				if ((!addMode) && (mainForm.todoContexts[lineNumber] == context))
				{
					contextComboBox.SelectedIndex = contextComboBox.Items.Count -1;
				}
			}

			// Projects
			foreach (var project in mainForm.todoProjectsStack)
			{
				projectComboBox.Items.Add(project);

				if ((!addMode) && (mainForm.todoProjects[lineNumber] == project))
				{
					projectComboBox.SelectedIndex = projectComboBox.Items.Count -1;
				}
			}

		}

		private void saveButton_Click(object sender, EventArgs e)
		{

		}


	}
}