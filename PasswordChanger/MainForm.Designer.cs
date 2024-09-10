namespace PasswordChanger
{
    partial class PasswordChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChanger));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            textPath = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnShow = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnGenerate = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            textSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuFileAbout = new System.Windows.Forms.ToolStripMenuItem();
            mnuFileConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            tableLayoutPanel1.Size = new System.Drawing.Size(547, 385);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel3
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel3, 2);
            flowLayoutPanel3.Controls.Add(textPath);
            flowLayoutPanel3.Controls.Add(btnLoad);
            flowLayoutPanel3.Controls.Add(btnShow);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 330);
            flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(541, 32);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // textPath
            // 
            textPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            textPath.Location = new System.Drawing.Point(3, 5);
            textPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textPath.Name = "textPath";
            textPath.Size = new System.Drawing.Size(287, 23);
            textPath.TabIndex = 1;
            textPath.TextChanged += textPath_TextChanged;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnLoad.AutoSize = true;
            btnLoad.Location = new System.Drawing.Point(296, 2);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(91, 30);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load CSV";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnShow
            // 
            btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnShow.AutoSize = true;
            btnShow.Location = new System.Drawing.Point(393, 2);
            btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(74, 30);
            btnShow.TabIndex = 0;
            btnShow.Text = "Explore";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnGenerate);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(385, 294);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(159, 32);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGenerate.AutoSize = true;
            btnGenerate.Location = new System.Drawing.Point(31, 2);
            btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new System.Drawing.Size(125, 30);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate PSW";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 2);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(541, 288);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(textSearch);
            flowLayoutPanel2.Controls.Add(btnSearch);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 294);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(376, 32);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // textSearch
            // 
            textSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            textSearch.Location = new System.Drawing.Point(3, 5);
            textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textSearch.Name = "textSearch";
            textSearch.Size = new System.Drawing.Size(287, 23);
            textSearch.TabIndex = 1;
            textSearch.TextChanged += textBox1_TextChanged;
            textSearch.KeyDown += textSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSearch.AutoSize = true;
            btnSearch.Location = new System.Drawing.Point(296, 2);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(70, 30);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Title = "Select a picture";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFile });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(547, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFileAbout, mnuFileConfiguration, toolStripMenuItem1, mnuFileQuit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "File";
            mnuFile.Click += mnuFile_Click;
            // 
            // mnuFileAbout
            // 
            mnuFileAbout.Name = "mnuFileAbout";
            mnuFileAbout.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A;
            mnuFileAbout.Size = new System.Drawing.Size(213, 22);
            mnuFileAbout.Text = "About";
            mnuFileAbout.Click += mnuFileAbout_Click;
            // 
            // mnuFileConfiguration
            // 
            mnuFileConfiguration.Name = "mnuFileConfiguration";
            mnuFileConfiguration.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C;
            mnuFileConfiguration.Size = new System.Drawing.Size(213, 22);
            mnuFileConfiguration.Text = "Configuration";
            mnuFileConfiguration.Click += mnuFileConfiguration_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // mnuFileQuit
            // 
            mnuFileQuit.Name = "mnuFileQuit";
            mnuFileQuit.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q;
            mnuFileQuit.Size = new System.Drawing.Size(213, 22);
            mnuFileQuit.Text = "Quit";
            mnuFileQuit.Click += mnuFileQuit_Click;
            // 
            // PasswordChanger
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(547, 409);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "PasswordChanger";
            Text = "Password Changer";
            Load += PasswordChanger_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuFileConfiguration;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
    }
}

