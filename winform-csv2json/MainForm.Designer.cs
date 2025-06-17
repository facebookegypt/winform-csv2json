namespace winform_csv2json
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.csvlocLbl = new System.Windows.Forms.Label();
            this.csvlocTextBox = new System.Windows.Forms.TextBox();
            this.savejsonTextBox = new System.Windows.Forms.TextBox();
            this.savejsonLbl = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.jsonLocbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MalformedGB = new System.Windows.Forms.GroupBox();
            this.malformedListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.MalformedGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // csvlocLbl
            // 
            this.csvlocLbl.AutoSize = true;
            this.csvlocLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvlocLbl.Location = new System.Drawing.Point(145, 54);
            this.csvlocLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.csvlocLbl.Name = "csvlocLbl";
            this.csvlocLbl.Size = new System.Drawing.Size(125, 20);
            this.csvlocLbl.TabIndex = 3;
            this.csvlocLbl.Text = "CSV file location";
            // 
            // csvlocTextBox
            // 
            this.csvlocTextBox.BackColor = System.Drawing.Color.White;
            this.csvlocTextBox.Location = new System.Drawing.Point(149, 77);
            this.csvlocTextBox.Multiline = true;
            this.csvlocTextBox.Name = "csvlocTextBox";
            this.csvlocTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.csvlocTextBox.Size = new System.Drawing.Size(339, 53);
            this.csvlocTextBox.TabIndex = 4;
            // 
            // savejsonTextBox
            // 
            this.savejsonTextBox.Location = new System.Drawing.Point(149, 245);
            this.savejsonTextBox.Multiline = true;
            this.savejsonTextBox.Name = "savejsonTextBox";
            this.savejsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.savejsonTextBox.Size = new System.Drawing.Size(339, 53);
            this.savejsonTextBox.TabIndex = 8;
            // 
            // savejsonLbl
            // 
            this.savejsonLbl.AutoSize = true;
            this.savejsonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savejsonLbl.Location = new System.Drawing.Point(145, 222);
            this.savejsonLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savejsonLbl.Name = "savejsonLbl";
            this.savejsonLbl.Size = new System.Drawing.Size(269, 20);
            this.savejsonLbl.TabIndex = 7;
            this.savejsonLbl.Text = "Where do you with to save Json file?!";
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(149, 136);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 9;
            this.openBtn.Text = "Bro&wse";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(413, 304);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // jsonLocbtn
            // 
            this.jsonLocbtn.Location = new System.Drawing.Point(149, 304);
            this.jsonLocbtn.Name = "jsonLocbtn";
            this.jsonLocbtn.Size = new System.Drawing.Size(75, 23);
            this.jsonLocbtn.TabIndex = 11;
            this.jsonLocbtn.Text = "Bro&wse";
            this.jsonLocbtn.UseVisualStyleBackColor = true;
            this.jsonLocbtn.Click += new System.EventHandler(this.jsonLocbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.resetToolStripMenuItem.Text = "Re&set";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.recentToolStripMenuItem.Text = "Rece&nt";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "e&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform_csv2json.Properties.Resources.csv_to_json;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 330);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(811, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(327, 22);
            this.toolStripLabel1.Text = "Evry1falls Copyright https://adonetaccess2003.blogspot.com";
            // 
            // MalformedGB
            // 
            this.MalformedGB.Controls.Add(this.malformedListBox);
            this.MalformedGB.Location = new System.Drawing.Point(494, 27);
            this.MalformedGB.Name = "MalformedGB";
            this.MalformedGB.Size = new System.Drawing.Size(305, 300);
            this.MalformedGB.TabIndex = 15;
            this.MalformedGB.TabStop = false;
            this.MalformedGB.Text = "Malformed Lines";
            this.MalformedGB.UseCompatibleTextRendering = true;
            // 
            // malformedListBox
            // 
            this.malformedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.malformedListBox.FormattingEnabled = true;
            this.malformedListBox.Location = new System.Drawing.Point(6, 19);
            this.malformedListBox.Name = "malformedListBox";
            this.malformedListBox.Size = new System.Drawing.Size(120, 91);
            this.malformedListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 355);
            this.Controls.Add(this.MalformedGB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.jsonLocbtn);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.savejsonTextBox);
            this.Controls.Add(this.savejsonLbl);
            this.Controls.Add(this.csvlocTextBox);
            this.Controls.Add(this.csvlocLbl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CSV files to Json Files - evry1falls";
            this.Load += new System.EventHandler(this.Mainform_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MalformedGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label csvlocLbl;
        private System.Windows.Forms.TextBox csvlocTextBox;
        private System.Windows.Forms.TextBox savejsonTextBox;
        private System.Windows.Forms.Label savejsonLbl;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button jsonLocbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox MalformedGB;
        private System.Windows.Forms.ListBox malformedListBox;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

