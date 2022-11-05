using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Notes
{
    public partial class Form1 : Form
    {
        CustomMessageBox warningBox = new CustomMessageBox();

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private String? currentFileName;
        public int findPos = 0;

        private bool saved;
        private bool findPanelShow = false;

        const int WM_USER = 0x400;

        const int EM_GETSCROLLPOS = WM_USER + 221;

        const int EM_SETSCROLLPOS = WM_USER + 222;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);


#pragma warning disable CS8618 
        public Form1()
#pragma warning restore CS8618
        {
            InitializeComponent();
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = "1";
        }

        private void MatchScroll()
        {
            Point pt = new Point();

            SendMessage(textArea.Handle, EM_GETSCROLLPOS, 0, ref pt);

            SendMessage(richTextBox1.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }
        private void textArea_VScroll(object sender, EventArgs e)
        {
            MatchScroll();
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            MatchScroll();
        }

        private void NewFile()
        {
            textArea.Text = String.Empty;
            Text = "Untitled";
            saved = false;
            saveStatus.BackColor = Color.FromArgb(41, 41, 50);
            currentFileName = null;
        }

        private void SaveFile()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File(*.txt) | *.txt";
            saveFileDialog.FileName = "Untitled";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = saveFileDialog.FileName;
                File.WriteAllText(saveFileDialog.FileName, textArea.Text);
                Text = currentFileName;
                saveStatus.BackColor = Color.FromArgb(41, 41, 50);
            }
        }
        private void ExitFile()
        {
            if (saved) return;

            var result = warningBox.TextForm("Are you sure?", $"Save changes before exiting", MessageBoxButtons.OKCancel, "Save", "Don't Save");
            if (result == DialogResult.OK)
            {
                if (File.Exists(currentFileName))
                {
                    textArea.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                    saveStatus.BackColor = Color.FromArgb(41, 41, 50);
                }
                else
                    SaveFile();
            }
        }

        private void OpenFile()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NewFile();
                currentFileName = openFileDialog.FileName;
                textArea.Text = File.ReadAllText(openFileDialog.FileName);
                Text = currentFileName;
                saved = true;
                saveStatus.BackColor = Color.FromArgb(41, 41, 50);

                ShowFileDetails();
            }
        }

        public void OpenFileArgs(string filePath)
        {
            string file = File.ReadAllText(filePath);
            textArea.Text = file;
            currentFileName = filePath;
            Text = currentFileName;
            saved = true;

            ShowFileDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(currentFileName))
            {
                Text = currentFileName;
                saveStatus.BackColor = Color.FromArgb(41, 41, 50);
            }
            else
            {
                Text = "Untitled*";
                saveStatus.BackColor = Color.Green;
            }
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {

            AddLineNumber();
            MatchScroll();
            saveStatus.BackColor = Color.Green;
            findPos = 0;
            if (File.Exists(currentFileName))
            {
                Text = currentFileName + "*";
            }
            else
                Text = "Untitled*";

            saved = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textArea.Text))
            {
                NewFile();
            }
            else
            {
                var result = warningBox.TextForm("Progress will be lost.", "Make sure you save your progress!", MessageBoxButtons.OKCancel, "New", "Cancel");
                if (result == DialogResult.OK)
                    NewFile();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saved = true;
            if (!File.Exists(currentFileName))
            {
                SaveFile();
            }
            else
            {
                textArea.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                saveStatus.BackColor = Color.FromArgb(41, 41, 50);
                Text = currentFileName;
            }
        }

        private void textArea_SelectionChanged(object sender, EventArgs e)
        {
            AddLineNumber();
            MatchScroll();
            ShowFileDetails();
        }

        private void CheckTextDetails()
        {
            int index = textArea.SelectionStart;
            int currentLine = textArea.GetLineFromCharIndex(index) + 1;
            int charsWs = textArea.Text.Length;
            int wordsNr = Regex.Matches(textArea.Text, @"\b[A-Za-z0-9]+\b").Count;
            string chars = textArea.Text.Replace(" ", "");

            label1.Text = "ln: " + currentLine.ToString()
                                 + " |  chars ws: " + charsWs.ToString()
                                 + " |  chars: " + chars.Length
                                 + " |  words: " + wordsNr.ToString();
        }

        private void ShowFileDetails()
        {

            CheckTextDetails();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFile();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ExitFile();
        }

        private void DisableFindBox()
        {
            findPos = 0;
            textArea.SelectionStart = 0;
            panel2.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                textArea.SelectionStart = 0;
                string s = textBox1.Text;
                textArea.Focus();
                findPos = textArea.Find(s, findPos, RichTextBoxFinds.MatchCase);
                textArea.Select(findPos, s.Length);
                findPos += 1;

            }
            catch
            {
                MessageBox.Show("No Occurences Found");
                findPos = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = textArea.Text.LastIndexOf(textBox1.Text);
            while (start < end)
            {
                textArea.Find(textBox1.Text, start, textArea.TextLength, RichTextBoxFinds.MatchCase);
                textArea.SelectionBackColor = Color.FromArgb(41, 41, 50);
                start = textArea.Text.IndexOf(textBox1.Text, start) + 1;
            }

            findPanelShow = !findPanelShow;
            DisableFindBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textArea.SelectionStart = 0;
            findPos = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = textArea.Text.LastIndexOf(textBox1.Text);
            while (start < end)
            {
                textArea.Find(textBox1.Text, start, textArea.TextLength, RichTextBoxFinds.MatchCase);
                textArea.SelectionBackColor = Color.FromArgb(70, 85, 70);
                start = textArea.Text.IndexOf(textBox1.Text, start) + 1;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            findPanelShow = !findPanelShow;
            if (findPanelShow)
            {
                panel2.Show();
                textBox1.Focus();
            }
            else
            {
                DisableFindBox();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                searchButton_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                btnOpen_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnNew_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnOptions_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                MatchScroll();
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Point screenPoint = btnOptions.PointToScreen(new Point(btnOptions.Left, btnOptions.Bottom));
            if (screenPoint.Y + contextMenuStrip1.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                contextMenuStrip1.Show(btnOptions, new Point(0, -contextMenuStrip1.Size.Height - 5));
            }
            else
            {
                contextMenuStrip1.Show(btnOptions, new Point(0, btnOptions.Height + 5));
            }
        }

        private void OpenTool_Click(object sender, EventArgs e)
        {
            btnOpen_Click(sender, e);
        }

        private void NewTool_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void saveAsTool_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveTool_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void FindTool_Click(object sender, EventArgs e)
        {
            searchButton_Click(sender, e);
        }

        private void FontTool_Click(object sender, EventArgs e)
        {

        }

        private void ExitTool_Click(object sender, EventArgs e)
        {
            ExitFile();
        }
        int maxLC = 1; //maxLineCount - should be public

        private void AddLineNumber()
        {
            int linecount = textArea.GetLineFromCharIndex(textArea.TextLength) + 1;
            if (linecount != maxLC)
            {
                richTextBox1.Clear();
                for (int i = 1; i < linecount + 1; i++)
                {
                    richTextBox1.AppendText(Convert.ToString(i) + "\n");
                }
                maxLC = linecount;
            }
        }
        private void textArea_KeyUp(object sender, KeyEventArgs e)
        {
            AddLineNumber();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AddLineNumber();
            MatchScroll();
            ShowFileDetails();
        }
    }
    
}
