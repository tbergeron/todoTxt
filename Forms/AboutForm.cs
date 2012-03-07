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
using System.Diagnostics;
using System.Windows.Forms;

namespace todoTxt
{
	/// <summary>
	/// About Dialog
	/// </summary>
	public partial class AboutForm : Form
	{
		#region Constructor & Events

		/// <summary>
		/// AboutForm's Constructor
		/// </summary>
		public AboutForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// AboutForm's Load event
		/// </summary>
		private void AboutForm_Load(object sender, EventArgs e)
		{
			string version = String.Empty;

			if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
			{
				System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
				version = ad.CurrentVersion.ToString();
			}
			else
			{
				version = "NOT_DEPLOYED";
			}

			Text = "todoTxt (v" + version + ")";
			
			aboutTextBox.Text = @"todoTxt
adding power to your todo.txt file!

Copyright (C) 2011 Tommy Bergeron @ Brainpad <www.brainpad.org>
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see http://www.gnu.org/licenses/.";
		}

		/// <summary>
		/// LinkLabel's linkclicked event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("start http://github.com/tbergeron/todoTxt");
		}

		#endregion
	}
}
