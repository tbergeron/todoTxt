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

		// Text file path & content
		public string todoTxtPath;
		public string todoContent;

		// Text highlightable strings
		public Regex highlightableStrings = new Regex(@"@\w*|\+\w*|[\n|\r]x\s|^x\s|\([ABCDE]{1}\)");

		// Text highlighting colors
		public Color defaultTextColor = Color.Black;
		public Color defaultBackColor = Color.White;
		public Color contextTextColor = Color.Blue;
		public Color projectTextColor = Color.Green;

		// Priorities colors
		public Color priorityATextColor = Color.Red;
		public Color priorityBTextColor = Color.OrangeRed;
		public Color priorityCTextColor = Color.Yellow;
		public Color priorityDTextColor = Color.YellowGreen;
		public Color priorityETextColor = Color.Green;
		public Color priorityBackColor = Color.Black;

		// Constuctor
		public MainForm()
		{
			InitializeComponent();
		}

		
		// Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			todoTxtPath = Properties.Settings.Default.todoTxtRecentPath;

			// Line numbers
			editor.Margins[0].Width = 20;

			// Highlight Current Line
			editor.Caret.HighlightCurrentLine = true;

			// Custom Scintilla configuration
			editor.ConfigurationManager.CustomLocation = "ScintillaNET.xml";
			editor.ConfigurationManager.Language = "lua";

			if (File.Exists(todoTxtPath))
			{
				OpenTodoTxt();
			}

		}

		private void editor_CharAdded(object sender, ScintillaNet.CharAddedEventArgs e)
		{
			// Dynamic keywords
			//if (e.Ch == ':')
			//{
			//    string wp = string.Empty;
			//    Regex r = new Regex(@"\b\w+[:\b]");
			//    MatchCollection m = r.Matches(editor.Text);
			//    for (int i = 0; i < m.Count; i++)
			//    {
			//        wp += " " + m[i].Value.Substring(0, m[i].Value.Length - 1);
			//    }
			//    editor.Lexing.Keywords[2] = wp;
			//}

			//if (e.Ch == '@')
			//{
			//    string keywords = string.Empty;
			//    string match = string.Empty;

			//    Regex regex = new Regex(@"@\w*");
			//    MatchCollection matches = regex.Matches(editor.Text);

			//    for (int i = 0; i < matches.Count; i++)
			//    {
			//        match = matches[i].Value.ToLower().Replace("@", "");

			//        if (!keywords.Contains(match))
			//        {
			//            keywords += match + " ";
			//        }
			//    }

			//    editor.Lexing.Keywords[2] = keywords.TrimEnd();
			//}
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
			//editor.SaveFile(todoTxtPath, RichTextBoxStreamType.PlainText);
		}

		
		// Methods
		public void OpenTodoTxt()
		{
			todoContent = File.ReadAllText(todoTxtPath, UTF8Encoding.UTF8);
			editor.Text = todoContent;

			//editor.Select(editor.TextLength, 0);
		}

	}
}
