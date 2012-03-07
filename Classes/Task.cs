using System;

namespace todoTxt.Classes
{
	/// <summary>
	/// Model class for Tasks.
	/// </summary>
	public class Task
	{
		#region Variables
		
		private int _iLineNumber;
		private string _sName;
		private string _sDueDate;
		private string _sProject;
		private string _sContext;
		private string _sPriority;
		private bool _bIsDone;
		
		#endregion

		#region Properties

		/// <summary>
		/// Line number for the task in the text file.
		/// </summary>
		public int LineNumber 
		{ 
			get
			{
				return _iLineNumber;
			}
			set
			{
				_iLineNumber = value;
			}
		}

		/// <summary>
		/// Task's name
		/// </summary>
		public string Name 
		{ 
			get
			{
				return _sName;
			}
			set
			{
				_sName = value;
			}
		}

		/// <summary>
		/// Task's due date
		/// </summary>
		public string DueDate 
		{ 
			get
			{
				return (String.IsNullOrEmpty(_sDueDate)) ? "None" : _sDueDate;
			}
			set
			{
				_sDueDate = value;
			}
		}

		/// <summary>
		/// Task's project
		/// </summary>
		public string Project 
		{ 
			get
			{
				return (String.IsNullOrEmpty(_sProject)) ? "None" : _sProject;
			}
			set
			{
				_sProject = value;
			}
		}

		/// <summary>
		/// Gets an empty string instead of none
		/// </summary>
		public string ProjectForSave
		{
			get
			{
				return (String.IsNullOrEmpty(_sProject)) ? "" : _sProject;
			}
		}

		/// <summary>
		/// Task's context
		/// </summary>
		public string Context 
		{
			get
			{
				return (String.IsNullOrEmpty(_sContext)) ? "None" : _sContext;
			}
			set
			{
				_sContext = value;
			}
		}

		/// <summary>
		/// Gets an empty string instead of none
		/// </summary>
		public string ContextForSave
		{
			get
			{
				return (String.IsNullOrEmpty(_sContext)) ? "" : _sContext;
			}
		}

		/// <summary>
		/// Task's priority
		/// </summary>
		public string Priority 
		{ 
			get
			{
				return _sPriority;
			}
			set
			{
				_sPriority = value;
			}
		}

		/// <summary>
		/// Gets an empty string instead of none
		/// </summary>
		public string PriorityForSave
		{
			get
			{
				return (String.IsNullOrEmpty(_sPriority)) ? "" : _sPriority;
			}
		}

		/// <summary>
		/// Task's priority (String format)
		/// </summary>
		public string PriorityString
		{
			get
			{
				string returnString = "None";

				if (_sPriority == "A") returnString = "A - Critical";
				if (_sPriority == "B") returnString = "B - High";
				if (_sPriority == "C") returnString = "C - Medium";
				if (_sPriority == "D") returnString = "D - Low";
				if (_sPriority == "E") returnString = "E - Non Important";

				return returnString;
			}
			set
			{
				_sPriority = value;
			}
		}

		/// <summary>
		/// Task's status
		/// </summary>
		public bool IsDone 
		{ 
			get
			{
				return _bIsDone;
			}
			set
			{
				_bIsDone = value;
			}
		 }

		/// <summary>
		/// Task's status (string format)
		/// </summary>
		public string IsDoneString
		{
			get
			{
				if (_bIsDone)
				{
					return "Done";
				}
				else
				{
					return "Not done yet";
				}
			}
			set
			{
				_bIsDone = (value == "True") ? true : false;
			}
		}

		#endregion
	}
}