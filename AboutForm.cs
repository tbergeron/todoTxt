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

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("start http://github.com/tbergeron/todoTxt");
			Process.Start(startInfo);
		}


		// Methods

		/// <summary>
		/// Opens the specified URL.
		/// </summary>
		public void OpenLink(string sUrl)
		{
			// TODO: Found no other legit way of opening the default browser. FFFFUUUUUUUUUU!
			try
			{
				Process.Start(sUrl);
			}
			catch (Exception e)
			{
				ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe", sUrl);
				Process.Start(startInfo);
				startInfo = null;
			}
		}

	}
}
