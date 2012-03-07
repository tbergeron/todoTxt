using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace todoTxt.Classes
{
	/// <summary>
	/// TaskCollection, contains a collection of Tasks.
	/// </summary>
	public class TaskCollection
	{
		#region Variables

		private List<Task> _oItems = new List<Task>();

		/// <summary>
		/// Regex for parsing the text file.
		/// </summary>
		private Regex doneRegex = new Regex(@"^x\s");
		private Regex priorityRegex = new Regex(@"\([ABCDE]{1}\)");
		private Regex dateRegex = new Regex(@"[0-9]{4}-[0-9]{2}-[0-9]{2}");
		private Regex contextRegex = new Regex(@"@\w*");
		private Regex projectRegex = new Regex(@"\+\w*");

		#endregion

		#region Properties

		public List<Task> Items 
		{ 
			get
			{
				return _oItems;
			} 
			set
			{
				_oItems = value;
			} 
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Gets the last line's number
		/// </summary>
		/// <returns></returns>
		public int GetLastLineNumber()
		{
			// Redorders the collection by LineNumber (descending)
			this.Items.OrderByDescending(t => t.LineNumber);

			// Returns the last task.
			return this.Items.Last().LineNumber;
		}

		/// <summary>
		/// Gets a list of Contexts.
		/// </summary>
		/// <returns>List of String</returns>
		public List<String> GetContexts()
		{
			List<string> oContexts = new List<string>();
			oContexts.Add("None");

			foreach (Task task in this.Items)
			{
				if (!oContexts.Contains(task.Context))
				{
					oContexts.Add(task.Context);
				}
			}

			return oContexts;
		}

		/// <summary>
		/// Gets a list of Projects.
		/// </summary>
		/// <returns>List of String</returns>
		public List<String> GetProjects()
		{
			List<string> oProjects = new List<string>();
			oProjects.Add("None");

			foreach (Task task in this.Items)
			{
				if (!oProjects.Contains(task.Project))
				{
					oProjects.Add(task.Project);
				}
			}

			return oProjects;
		}

		/// <summary>
		/// Loops through ObjectListView's tasks and writes the text file content.
		/// </summary>
		/// <returns>Boolean</returns>
		public bool Save(string p_sFilePath)
		{
			try
			{
				// Reordering the collection by line numbers.
				this.Items.OrderBy(t => t.LineNumber);

				int iLineNumber = 0;

				using (TextWriter writer = new StreamWriter(p_sFilePath))
				{
					foreach (Task task in this.Items)
					{
						string lineToWrite = String.Empty;

						// If the task is done.
						if (task.IsDone)
						{
							lineToWrite = "x ";
						}

						// Due Date
						lineToWrite = lineToWrite + task.DueDate + " ";

						if (task.PriorityForSave.Length > 0)
						{
							lineToWrite = lineToWrite + "(" + task.PriorityForSave + ") ";
						}

						// Task
						lineToWrite = lineToWrite + task.Name + " ";

						// Context
						lineToWrite = lineToWrite + task.ContextForSave + " ";

						// Project
						lineToWrite = lineToWrite + task.ProjectForSave + " ";

						// Inserts the generated line into the file.
						if (lineToWrite != null)
						{
							writer.WriteLine(lineToWrite);
						}

						iLineNumber++;
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		/// <summary>
		/// Parses the text file and creates Task for every lines.
		/// </summary>
		/// <param name="p_sFilePath">String</param>
		public void ParseTextFile(string p_sFilePath)
		{
			string[] todoContentLines = File.ReadAllLines(p_sFilePath);

			string date = String.Empty;
			string priority = String.Empty;
			string task = String.Empty;
			string context = String.Empty;
			string project = String.Empty;

			int lineNumber = 0;
			foreach (string line in todoContentLines)
			{
				Task oTask = new Task();

				date = "";
				priority = "";
				context = "";
				project = "";
				task = line;

				if (priorityRegex.Match(line).Success)
				{
					priority = priorityRegex.Match(line).Value;
					task = task.Replace(priority + " ", "");
					oTask.Priority = priority.Replace("(", "").Replace(")", "");
				}

				if (dateRegex.Match(line).Success)
				{
					date = dateRegex.Match(line).Value;
					task = task.Replace(date + " ", "");
					oTask.DueDate = date;
				}

				if (contextRegex.Match(line).Success)
				{
					context = contextRegex.Match(line).Value;
					task = task.Replace(context, "");
					oTask.Context = context;
				}

				if (projectRegex.Match(line).Success)
				{
					project = projectRegex.Match(line).Value;
					task = task.Replace(project, "");
					oTask.Project = project;
				}

				oTask.LineNumber = lineNumber;
				oTask.Name = task.Replace("x ", "");
				oTask.IsDone = (doneRegex.Match(line).Success) ? true : false;

				this.Items.Add(oTask);

				lineNumber++;
			}
		}

		/// <summary>
		/// Removes a task
		/// </summary>
		/// <param name="p_oTask">Task</param>
		/// <returns>Boolean</returns>
		public bool Remove(Task p_oTask)
		{
			try
			{
				// Creating a fake collection containing the task for removal.
				TaskCollection oFakeTaskCollection = new TaskCollection();
				oFakeTaskCollection.Items.Add(p_oTask);

				// Getting the new list of tasks without the removed one.
				IEnumerable<Task> oTasksWithoutException = new List<Task>();
				oTasksWithoutException = this.Items.Except(oFakeTaskCollection.Items);

				// Setting the new list as the collection.
				this.Items = (List<Task>)oTasksWithoutException;

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		#endregion
	}
}
