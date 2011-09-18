using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// TODO : BUG : Fuck d'encoding des accents

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

			if (File.Exists(todoTxtPath))
			{
				OpenTodoTxt();
			}

		}

		private void editor_KeyUp(object sender, KeyEventArgs e)
		{
			HighlightLine(editor.GetLineFromCharIndex(editor.SelectionStart));
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
			editor.SaveFile(todoTxtPath, RichTextBoxStreamType.PlainText);
		}

		
		// Methods
		public void OpenTodoTxt()
		{
			editor.Clear();

			todoContent = File.ReadAllText(todoTxtPath, UTF8Encoding.UTF8);
			editor.Text = todoContent;

			HighlightLines();

			editor.Select(editor.TextLength, 0);
		}

		public void HighlightLines()
		{
			int currentLineIndex = 0;
			int totalLines = editor.Lines.Count() -1;

			while (currentLineIndex <= totalLines)
			{
				HighlightLine(currentLineIndex);

				currentLineIndex++;
			}
		}

		public void HighlightLine(int lineIndex)
		{
			int selectionPosition = editor.SelectionStart;

			foreach (Match highlightableString in highlightableStrings.Matches(editor.Lines[lineIndex]))
			{
				try
				{
					int highlightableStringIndex = editor.GetFirstCharIndexFromLine(lineIndex) + highlightableString.Index;

					editor.Select(highlightableStringIndex, highlightableString.Length);

					// Done task
					if ((highlightableString.ToString().Contains("x")) && (highlightableString.Length < 4))
					{
						// Selecting the WHOLE line.
						int selectedLineIndex = editor.GetLineFromCharIndex(highlightableStringIndex);
						int lineLength = editor.Lines[selectedLineIndex].Length + 1;
						editor.Select(highlightableStringIndex, lineLength);

						// Striking out the whole line.
						editor.SelectionFont = new Font(editor.SelectionFont, FontStyle.Strikeout);
					}

					// Priority
					// TODO : BUG : Problème si on écrit quelque chose dans les parenthèses.
					else if ((highlightableString.ToString().Contains("(")) && (highlightableString.ToString().Contains(")")))
					{
						editor.SelectionLength = editor.SelectionLength;

						if (highlightableString.ToString().Contains("A"))
						{
							editor.SelectionColor = priorityATextColor;
						}
						else if (highlightableString.ToString().Contains("B"))
						{
							editor.SelectionColor = priorityBTextColor;
						}
						else if (highlightableString.ToString().Contains("C"))
						{
							editor.SelectionColor = priorityCTextColor;
						}
						else if (highlightableString.ToString().Contains("D"))
						{
							editor.SelectionColor = priorityDTextColor;
						}
						else if (highlightableString.ToString().Contains("E"))
						{
							editor.SelectionColor = priorityETextColor;
						}

						editor.SelectionBackColor = priorityBackColor;
					}

					// Context reference
					else if (highlightableString.ToString().Contains("@"))
					{
						editor.SelectionColor = contextTextColor;
					}

					// Project reference
					else if (highlightableString.ToString().Contains("+"))
					{
						editor.SelectionColor = projectTextColor;
					}

					// After the highlightment we put the cursor back to its initial position.
					editor.SelectionStart = selectionPosition;
					editor.SelectionLength = 0;
					editor.SelectionColor = defaultTextColor;
					editor.SelectionBackColor = defaultBackColor;
				}
				catch (Exception e)
				{
					MessageBox.Show(e.InnerException.ToString());
				}
			}
		}

	}
}
