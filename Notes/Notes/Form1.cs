namespace Notes
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private String currentFileName;
        private bool saved;
        private bool modified;

        public Form1()
        {
            InitializeComponent();
        }
        private void NewFile()
        {
            textArea.Text = String.Empty;
            Text = "Untitled";
            saved = false;
            button2.BackColor = Color.FromArgb(41, 41, 50);
        }
              
        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(textArea.Text))
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File(*.txt) | *.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFileName = saveFileDialog.FileName;
                    File.WriteAllText(saveFileDialog.FileName, textArea.Text);
                    Text = currentFileName;
                    saved = true;
                    button2.BackColor = Color.FromArgb(41, 41, 50);
                }
            }
            else
            {
                MessageBox.Show("There is nothing to save.");
            }
        }

        private void OpenFile()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NewFile();
                currentFileName = openFileDialog.SafeFileName;
                textArea.Text = File.ReadAllText(openFileDialog.FileName);
                Text = currentFileName;
                saved = true;
                button2.BackColor = Color.FromArgb(41,41,50);
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
                var result = MessageBox.Show("Your progress will be lost!", "Are you sure?", MessageBoxButtons.OKCancel);
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
            if (string.IsNullOrEmpty(textArea.Text) || !saved)
            {
                SaveFile();
            }
            else
            {
                textArea.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                button2.BackColor = Color.FromArgb(41,41,50);
                Text = currentFileName;
            }
        }

        private void saveAsTool_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitTool_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textArea.Text) && !saved)
            {
                SaveFile();
            }
            else
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Untitled*";
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;

            Text = currentFileName + "*";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textArea.Text))
            {
                NewFile();
            }
            else
            {
                var result = MessageBox.Show("Your progress will be lost!", "Are you sure?", MessageBoxButtons.OKCancel);
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
            if (string.IsNullOrEmpty(textArea.Text) || !saved)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textArea.Text) && !saved)
            {
                var result = MessageBox.Show($"Do you want to save changes to {currentFileName}", "Are you sure?", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    SaveFile();
                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textArea.Font = fontDialog.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}