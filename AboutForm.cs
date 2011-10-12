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
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace todoTxt
{
	/// <summary>
	/// About Dialog
	/// </summary>
	public partial class AboutForm : Form
	{
		// Constructor

		public AboutForm()
		{
			InitializeComponent();
		}


		// Events

		private void AboutForm_Load(object sender, EventArgs e)
		{
			// Version number
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

			// Build date
			FileInfo appInfo = new FileInfo(Assembly.GetExecutingAssembly().Location);
			DateTime appBuildDate = appInfo.LastWriteTime;


			Text = "todoTxt (v" + version + ")";

			versionTextLabel.Text = "Version " + version + ", Released " + appBuildDate.ToString("yyyy-M-d");
		}

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("start http://github.com/tbergeron/todoTxt");
		}

	}
}
