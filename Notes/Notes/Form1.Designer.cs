namespace Notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.saveStatus = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.sepToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.FindTool = new System.Windows.Forms.ToolStripMenuItem();
            this.FontTool = new System.Windows.Forms.ToolStripMenuItem();
            this.divider = new System.Windows.Forms.ToolStripSeparator();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArea
            // 
            this.textArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.ForeColor = System.Drawing.Color.White;
            this.textArea.Location = new System.Drawing.Point(52, 44);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(940, 434);
            this.textArea.TabIndex = 0;
            this.textArea.Text = "";
            this.textArea.SelectionChanged += new System.EventHandler(this.textArea_SelectionChanged);
            this.textArea.VScroll += new System.EventHandler(this.textArea_VScroll);
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            this.textArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textArea_KeyUp);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNew.Location = new System.Drawing.Point(314, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(71, 27);
            this.btnNew.TabIndex = 2;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSaveAs.Location = new System.Drawing.Point(219, 6);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(89, 27);
            this.btnSaveAs.TabIndex = 7;
            this.btnSaveAs.TabStop = false;
            this.btnSaveAs.Text = "Save as...";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // saveStatus
            // 
            this.saveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.saveStatus.Enabled = false;
            this.saveStatus.FlatAppearance.BorderSize = 0;
            this.saveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStatus.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveStatus.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.saveStatus.Location = new System.Drawing.Point(143, 18);
            this.saveStatus.Name = "saveStatus";
            this.saveStatus.Size = new System.Drawing.Size(5, 5);
            this.saveStatus.TabIndex = 6;
            this.saveStatus.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(137, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpen.Location = new System.Drawing.Point(54, 6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(77, 27);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.TabStop = false;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnTest);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(809, 3);
            this.panel2.MaximumSize = new System.Drawing.Size(185, 33);
            this.panel2.MinimumSize = new System.Drawing.Size(185, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 33);
            this.panel2.TabIndex = 10;
            this.panel2.TabStop = true;
            this.panel2.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(99, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "s";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(157, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTest.Location = new System.Drawing.Point(128, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(23, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = ">";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ln: 100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.DimGray;
            this.fontDialog1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontDialog1.ShowColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panelButtons.Controls.Add(this.btnOptions);
            this.panelButtons.Controls.Add(this.searchButton);
            this.panelButtons.Controls.Add(this.btnSaveAs);
            this.panelButtons.Controls.Add(this.panel2);
            this.panelButtons.Controls.Add(this.btnNew);
            this.panelButtons.Controls.Add(this.btnOpen);
            this.panelButtons.Controls.Add(this.saveStatus);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Location = new System.Drawing.Point(-2, -1);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1012, 39);
            this.panelButtons.TabIndex = 11;
            this.panelButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptions.BackgroundImage")));
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOptions.Location = new System.Drawing.Point(17, 8);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(31, 25);
            this.btnOptions.TabIndex = 11;
            this.btnOptions.TabStop = false;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = global::Notes.Properties.Resources.search_3_16;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchButton.Location = new System.Drawing.Point(776, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(27, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.TabStop = false;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Location = new System.Drawing.Point(-2, 488);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(1012, 30);
            this.panelDetails.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip1.BackgroundImage = global::Notes.Properties.Resources.bg;
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTool,
            this.NewTool,
            this.saveAsTool,
            this.SaveTool,
            this.sepToolStripMenuItem,
            this.FindTool,
            this.FontTool,
            this.divider,
            this.ExitTool});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 170);
            // 
            // OpenTool
            // 
            this.OpenTool.BackgroundImage = global::Notes.Properties.Resources.asd;
            this.OpenTool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenTool.ForeColor = System.Drawing.Color.White;
            this.OpenTool.Name = "OpenTool";
            this.OpenTool.Size = new System.Drawing.Size(113, 22);
            this.OpenTool.Text = "Open...";
            this.OpenTool.Click += new System.EventHandler(this.OpenTool_Click);
            // 
            // NewTool
            // 
            this.NewTool.BackgroundImage = global::Notes.Properties.Resources.asd;
            this.NewTool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewTool.ForeColor = System.Drawing.Color.White;
            this.NewTool.Name = "NewTool";
            this.NewTool.Size = new System.Drawing.Size(113, 22);
            this.NewTool.Text = "New";
            this.NewTool.Click += new System.EventHandler(this.NewTool_Click);
            // 
            // saveAsTool
            // 
            this.saveAsTool.BackgroundImage = global::Notes.Properties.Resources.asd;
            this.saveAsTool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveAsTool.ForeColor = System.Drawing.Color.White;
            this.saveAsTool.Name = "saveAsTool";
            this.saveAsTool.Size = new System.Drawing.Size(113, 22);
            this.saveAsTool.Text = "Save as...";
            this.saveAsTool.Click += new System.EventHandler(this.saveAsTool_Click);
            // 
            // SaveTool
            // 
            this.SaveTool.BackgroundImage = global::Notes.Properties.Resources.asd;
            this.SaveTool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveTool.ForeColor = System.Drawing.Color.White;
            this.SaveTool.Name = "SaveTool";
            this.SaveTool.Size = new System.Drawing.Size(113, 22);
            this.SaveTool.Text = "Save";
            this.SaveTool.Click += new System.EventHandler(this.SaveTool_Click);
            // 
            // sepToolStripMenuItem
            // 
            this.sepToolStripMenuItem.Name = "sepToolStripMenuItem";
            this.sepToolStripMenuItem.Size = new System.Drawing.Size(110, 6);
            // 
            // FindTool
            // 
            this.FindTool.BackgroundImage = global::Notes.Properties.Resources.asd;
            this.FindTool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindTool.ForeColor = System.Drawing.Color.White;
            this.FindTool.Name = "FindTool";
            this.FindTool.Size = new System.Drawing.Size(113, 22);
            this.FindTool.Text = "Find...";
            this.FindTool.Click += new System.EventHandler(this.FindTool_Click);
            // 
            // FontTool
            // 
            this.FontTool.BackgroundImage = global::Notes.Properties.Resources.asd;
            this.FontTool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FontTool.ForeColor = System.Drawing.Color.White;
            this.FontTool.Name = "FontTool";
            this.FontTool.Size = new System.Drawing.Size(113, 22);
            this.FontTool.Text = "Font";
            this.FontTool.Click += new System.EventHandler(this.FontTool_Click);
            // 
            // divider
            // 
            this.divider.ForeColor = System.Drawing.Color.White;
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(110, 6);
            // 
            // ExitTool
            // 
            this.ExitTool.BackgroundImage = global::Notes.Properties.Resources.asd;
            this.ExitTool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitTool.ForeColor = System.Drawing.Color.White;
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(113, 22);
            this.ExitTool.Text = "Exit";
            this.ExitTool.Click += new System.EventHandler(this.ExitTool_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Location = new System.Drawing.Point(-2, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(48, 438);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1004, 520);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.textArea);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(650, 150);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnNew;
        private Button btnOpen;
        private Button btnSave;
        private Button saveStatus;
        private EventHandler button2_Click;
        private FontDialog fontDialog1;
        private Label label1;
        private Button btnSaveAs;
        internal RichTextBox textArea;
        private Button btnTest;
        private TextBox textBox1;
        private Panel panel2;
        private Button button3;
        private Button btnSearch;
        private Panel panelButtons;
        private Panel panelDetails;
        private Button searchButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem OpenTool;
        private ToolStripMenuItem NewTool;
        private Button btnOptions;
        private ToolStripMenuItem SaveTool;
        private ToolStripMenuItem saveAsTool;
        private ToolStripSeparator sepToolStripMenuItem;
        private ToolStripMenuItem FindTool;
        private ToolStripMenuItem FontTool;
        private ToolStripSeparator divider;
        private ToolStripMenuItem ExitTool;
        private RichTextBox richTextBox1;
    }
}