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
        private int amountToDropTheTextArea = 22;

        private bool saved;
        private bool findPanelShow = false;


#pragma warning disable CS8618 
        public Form1()
#pragma warning restore CS8618
        {
            InitializeComponent();
        }
        private void NewFile()
        {
            textArea.Text = String.Empty;
            Text = "Untitled";
            saved = false;
            button2.BackColor = Color.FromArgb(41, 41, 50);
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
                button2.BackColor = Color.FromArgb(41, 41, 50);
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
                    button2.BackColor = Color.FromArgb(41, 41, 50);
                }
                else
                    SaveFile();
            }
        }
        private void newTool_Click(object sender, EventArgs e)
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

        private void openTool_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveTool_Click(object sender, EventArgs e)
        {
            saved = true;
            if (!File.Exists(currentFileName))
            {
                SaveFile();
            }
            else
            {
                textArea.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                button2.BackColor = Color.FromArgb(41, 41, 50);
                Text = currentFileName;
            }
        }

        private void saveAsTool_Click(object sender, EventArgs e)
        {
            saved = true;
            SaveFile();
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
                button2.BackColor = Color.FromArgb(41, 41, 50);

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
                button2.BackColor = Color.FromArgb(41, 41, 50);
            }
            else
            {
                Text = "Untitled*";
                button2.BackColor = Color.Green;
            }
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
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
                button2.BackColor = Color.FromArgb(41, 41, 50);
                Text = currentFileName;
            }
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontDialog.Color = Color.Green;
                textArea.Font = fontDialog.Font;
            }
        }

        private void textArea_SelectionChanged(object sender, EventArgs e)
        {
            ShowFileDetails();
        }

        private void CheckNumberOfTotalLines()
        {
            int index = textArea.SelectionStart;
            int currentLine = textArea.GetLineFromCharIndex(index);
            label1.Text = "ln: " + currentLine.ToString();
        }

        private void CheckNumberOfWords()
        {
            int wordCount = Regex.Matches(textArea.Text, @"\b[A-Za-z0-9]+\b").Count;
            label3.Text = "words: " + wordCount.ToString();
            
        }

        private void CheckNumberOfLettersWithSpaces()
        { 
            int wordCount = textArea.Text.Length;
            label4.Text = "chars ws: "  + wordCount.ToString();
        }

        private void CheckNumberOfLetters()
        {
            string wordCount = textArea.Text.Replace(" ", "");
            label5.Text = "chars: " + wordCount.Length;
        }

        private void ShowFileDetails()
        {
            CheckNumberOfTotalLines();
            CheckNumberOfWords();
            CheckNumberOfLettersWithSpaces();
            CheckNumberOfLetters();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void toUppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = textArea.Text.ToUpper();
        }

        private void toLowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = textArea.Text.ToLower();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ExitFile();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            ShowFileDetails();
        }

        
        private void findInFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findPanelShow = !findPanelShow;
            if (findPanelShow)
            {
                panel2.Show();
                textBox1.Focus();
                textArea.Location = new Point(textArea.Location.X, textArea.Location.Y + amountToDropTheTextArea);
                textArea.Size = new Size(textArea.Size.Width, textArea.Size.Height - amountToDropTheTextArea);
            }
            else
            {
                DisableFindBox();
            }
        }
        private void DisableFindBox()
        {
            findPos = 0;
            textArea.SelectionStart = 0;
            panel2.Hide();
            textArea.Location = new Point(textArea.Location.X, textArea.Location.Y - amountToDropTheTextArea);
            textArea.Size = new Size(textArea.Size.Width, textArea.Size.Height + amountToDropTheTextArea);
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
            findPanelShow = !findPanelShow;
            DisableFindBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textArea.SelectionStart = 0;
            findPos = 0;
        }
    }
}