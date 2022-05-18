namespace RajapintaTehtava
{
    partial class Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRnd = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.webVideo = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.tbAuth = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gbBookmarks = new System.Windows.Forms.GroupBox();
            this.btnExpandBM = new System.Windows.Forms.Button();
            this.btnAddBookmark = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbBookmarks.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRnd
            // 
            this.btnRnd.Location = new System.Drawing.Point(6, 19);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(75, 23);
            this.btnRnd.TabIndex = 1;
            this.btnRnd.Text = "Random";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // pBox
            // 
            this.pBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox.Location = new System.Drawing.Point(532, 41);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(571, 465);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.webVideo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.tbURL);
            this.groupBox1.Controls.Add(this.lbCopyright);
            this.groupBox1.Controls.Add(this.rtb);
            this.groupBox1.Controls.Add(this.pBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 559);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(958, 515);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 13);
            this.lbDate.TabIndex = 5;
            // 
            // webVideo
            // 
            this.webVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webVideo.Location = new System.Drawing.Point(535, 132);
            this.webVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webVideo.Name = "webVideo";
            this.webVideo.Size = new System.Drawing.Size(568, 296);
            this.webVideo.TabIndex = 3;
            this.webVideo.TabStop = false;
            this.webVideo.Url = new System.Uri("", System.UriKind.Relative);
            this.webVideo.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text Size:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(67, 532);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            65536});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Location = new System.Drawing.Point(754, 19);
            this.tbURL.Name = "tbURL";
            this.tbURL.ReadOnly = true;
            this.tbURL.Size = new System.Drawing.Size(349, 20);
            this.tbURL.TabIndex = 3;
            // 
            // lbCopyright
            // 
            this.lbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Location = new System.Drawing.Point(532, 515);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCopyright.Size = new System.Drawing.Size(10, 13);
            this.lbCopyright.TabIndex = 4;
            this.lbCopyright.Text = ".";
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb.Location = new System.Drawing.Point(7, 20);
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            this.rtb.Size = new System.Drawing.Size(519, 508);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            this.rtb.ZoomFactor = 1.4F;
            // 
            // tbAuth
            // 
            this.tbAuth.Location = new System.Drawing.Point(60, 14);
            this.tbAuth.Name = "tbAuth";
            this.tbAuth.Size = new System.Drawing.Size(305, 20);
            this.tbAuth.TabIndex = 2;
            this.tbAuth.UseSystemPasswordChar = true;
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(2, 17);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(52, 13);
            this.lbKey.TabIndex = 1;
            this.lbKey.Text = "Auth key:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnToday);
            this.groupBox2.Controls.Add(this.btnRnd);
            this.groupBox2.Location = new System.Drawing.Point(12, 636);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 52);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(88, 19);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 2;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowPanel.Location = new System.Drawing.Point(6, 14);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(515, 23);
            this.flowPanel.TabIndex = 1;
            // 
            // gbBookmarks
            // 
            this.gbBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBookmarks.Controls.Add(this.btnExpandBM);
            this.gbBookmarks.Controls.Add(this.btnAddBookmark);
            this.gbBookmarks.Controls.Add(this.btnManage);
            this.gbBookmarks.Controls.Add(this.flowPanel);
            this.gbBookmarks.Location = new System.Drawing.Point(389, 27);
            this.gbBookmarks.Name = "gbBookmarks";
            this.gbBookmarks.Size = new System.Drawing.Size(732, 43);
            this.gbBookmarks.TabIndex = 9;
            this.gbBookmarks.TabStop = false;
            this.gbBookmarks.Text = "Bookmarks";
            // 
            // btnExpandBM
            // 
            this.btnExpandBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandBM.Location = new System.Drawing.Point(527, 14);
            this.btnExpandBM.Name = "btnExpandBM";
            this.btnExpandBM.Size = new System.Drawing.Size(23, 23);
            this.btnExpandBM.TabIndex = 2;
            this.btnExpandBM.Text = "🡣";
            this.btnExpandBM.UseVisualStyleBackColor = true;
            this.btnExpandBM.Click += new System.EventHandler(this.btnExpandBM_Click);
            // 
            // btnAddBookmark
            // 
            this.btnAddBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBookmark.Location = new System.Drawing.Point(556, 14);
            this.btnAddBookmark.Name = "btnAddBookmark";
            this.btnAddBookmark.Size = new System.Drawing.Size(75, 23);
            this.btnAddBookmark.TabIndex = 3;
            this.btnAddBookmark.Text = "Add Current";
            this.btnAddBookmark.UseVisualStyleBackColor = true;
            this.btnAddBookmark.Click += new System.EventHandler(this.btnAddBookmark_Click);
            // 
            // btnManage
            // 
            this.btnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManage.Location = new System.Drawing.Point(637, 14);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(86, 23);
            this.btnManage.TabIndex = 4;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbKey);
            this.groupBox4.Controls.Add(this.tbAuth);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 43);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "API Authorization";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickAbout});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // clickAbout
            // 
            this.clickAbout.Name = "clickAbout";
            this.clickAbout.Size = new System.Drawing.Size(182, 22);
            this.clickAbout.Text = "Creator: Leevi Eskola";
            this.clickAbout.Click += new System.EventHandler(this.clickAbout_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 706);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbBookmarks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Application";
            this.Text = "Application";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbBookmarks.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRnd;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAuth;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webVideo;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.GroupBox gbBookmarks;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnAddBookmark;
        private System.Windows.Forms.Button btnExpandBM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickAbout;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

