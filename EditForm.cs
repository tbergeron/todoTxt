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
	public partial class EditForm : Form
	{
		public bool addMode = false;
		public int lineNumber = 0;

		public EditForm()
		{
			InitializeComponent();
		}

		private void EditForm_Load(object sender, EventArgs e)
		{

		}
	}
}
