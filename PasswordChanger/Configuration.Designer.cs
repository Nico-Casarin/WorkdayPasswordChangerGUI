namespace PasswordChanger
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btn_Discard = new System.Windows.Forms.Button();
            btn_Save = new System.Windows.Forms.Button();
            flowLayoutPanel_CSVPath = new System.Windows.Forms.FlowLayoutPanel();
            lbl_Password = new System.Windows.Forms.Label();
            text_Passwd = new System.Windows.Forms.TextBox();
            flowLayoutPanel_Psw = new System.Windows.Forms.FlowLayoutPanel();
            lbl_Path = new System.Windows.Forms.Label();
            text_Path = new System.Windows.Forms.TextBox();
            flowLayoutPanel_Username = new System.Windows.Forms.FlowLayoutPanel();
            lbl_Username = new System.Windows.Forms.Label();
            text_Username = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel_APIURL = new System.Windows.Forms.FlowLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            text_API = new System.Windows.Forms.TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel_CSVPath.SuspendLayout();
            flowLayoutPanel_Psw.SuspendLayout();
            flowLayoutPanel_Username.SuspendLayout();
            flowLayoutPanel_APIURL.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 7);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel_CSVPath, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel_Psw, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel_Username, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel_APIURL, 0, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5005007F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5005007F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5005007F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.4964962F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5005007F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5005007F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5005007F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5005007F));
            tableLayoutPanel1.Size = new System.Drawing.Size(476, 359);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_Discard);
            flowLayoutPanel1.Controls.Add(btn_Save);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 311);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(468, 45);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_Discard
            // 
            btn_Discard.Location = new System.Drawing.Point(376, 3);
            btn_Discard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Discard.Name = "btn_Discard";
            btn_Discard.Size = new System.Drawing.Size(88, 27);
            btn_Discard.TabIndex = 0;
            btn_Discard.Text = "Discard";
            btn_Discard.UseVisualStyleBackColor = true;
            btn_Discard.Click += btn_Discard_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new System.Drawing.Point(280, 3);
            btn_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new System.Drawing.Size(88, 27);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // flowLayoutPanel_CSVPath
            // 
            flowLayoutPanel_CSVPath.Controls.Add(lbl_Path);
            flowLayoutPanel_CSVPath.Controls.Add(text_Path);
            flowLayoutPanel_CSVPath.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel_CSVPath.Location = new System.Drawing.Point(4, 135);
            flowLayoutPanel_CSVPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel_CSVPath.Name = "flowLayoutPanel_CSVPath";
            flowLayoutPanel_CSVPath.Size = new System.Drawing.Size(468, 38);
            flowLayoutPanel_CSVPath.TabIndex = 3;
            // 
            // lbl_Password
            // 
            lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_Password.Location = new System.Drawing.Point(4, 7);
            lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new System.Drawing.Size(60, 15);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            // 
            // text_Passwd
            // 
            text_Passwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            text_Passwd.Location = new System.Drawing.Point(72, 3);
            text_Passwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            text_Passwd.Name = "text_Passwd";
            text_Passwd.PasswordChar = '*';
            text_Passwd.Size = new System.Drawing.Size(383, 23);
            text_Passwd.TabIndex = 2;
            text_Passwd.TextChanged += text_Passwd_TextChanged;
            // 
            // flowLayoutPanel_Psw
            // 
            flowLayoutPanel_Psw.Controls.Add(lbl_Password);
            flowLayoutPanel_Psw.Controls.Add(text_Passwd);
            flowLayoutPanel_Psw.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel_Psw.Location = new System.Drawing.Point(4, 91);
            flowLayoutPanel_Psw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel_Psw.Name = "flowLayoutPanel_Psw";
            flowLayoutPanel_Psw.Size = new System.Drawing.Size(468, 38);
            flowLayoutPanel_Psw.TabIndex = 4;
            // 
            // lbl_Path
            // 
            lbl_Path.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_Path.Location = new System.Drawing.Point(4, 7);
            lbl_Path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Path.Name = "lbl_Path";
            lbl_Path.Size = new System.Drawing.Size(60, 15);
            lbl_Path.TabIndex = 1;
            lbl_Path.Text = "CSV Path";
            // 
            // text_Path
            // 
            text_Path.Anchor = System.Windows.Forms.AnchorStyles.None;
            text_Path.Location = new System.Drawing.Point(72, 3);
            text_Path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            text_Path.Name = "text_Path";
            text_Path.Size = new System.Drawing.Size(383, 23);
            text_Path.TabIndex = 2;
            // 
            // flowLayoutPanel_Username
            // 
            flowLayoutPanel_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanel_Username.Controls.Add(lbl_Username);
            flowLayoutPanel_Username.Controls.Add(text_Username);
            flowLayoutPanel_Username.Location = new System.Drawing.Point(4, 50);
            flowLayoutPanel_Username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel_Username.Name = "flowLayoutPanel_Username";
            flowLayoutPanel_Username.Size = new System.Drawing.Size(468, 32);
            flowLayoutPanel_Username.TabIndex = 2;
            // 
            // lbl_Username
            // 
            lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new System.Drawing.Point(4, 7);
            lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new System.Drawing.Size(60, 15);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username";
            lbl_Username.Click += label1_Click;
            // 
            // text_Username
            // 
            text_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            text_Username.Location = new System.Drawing.Point(72, 3);
            text_Username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            text_Username.Name = "text_Username";
            text_Username.Size = new System.Drawing.Size(383, 23);
            text_Username.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(150, 6);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(176, 31);
            label1.TabIndex = 5;
            label1.Text = "Configuration";
            label1.Click += label1_Click_1;
            // 
            // flowLayoutPanel_APIURL
            // 
            flowLayoutPanel_APIURL.Controls.Add(label2);
            flowLayoutPanel_APIURL.Controls.Add(text_API);
            flowLayoutPanel_APIURL.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel_APIURL.Location = new System.Drawing.Point(3, 179);
            flowLayoutPanel_APIURL.Name = "flowLayoutPanel_APIURL";
            flowLayoutPanel_APIURL.Size = new System.Drawing.Size(470, 38);
            flowLayoutPanel_APIURL.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.Location = new System.Drawing.Point(4, 7);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "API URL";
            label2.Click += label2_Click;
            // 
            // text_API
            // 
            text_API.Anchor = System.Windows.Forms.AnchorStyles.None;
            text_API.Location = new System.Drawing.Point(72, 3);
            text_API.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            text_API.Name = "text_API";
            text_API.Size = new System.Drawing.Size(384, 23);
            text_API.TabIndex = 3;
            text_API.TextChanged += textBox1_TextChanged;
            // 
            // Config
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(476, 359);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Config";
            Text = "Configuration";
            Load += Form3_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel_CSVPath.ResumeLayout(false);
            flowLayoutPanel_CSVPath.PerformLayout();
            flowLayoutPanel_Psw.ResumeLayout(false);
            flowLayoutPanel_Psw.PerformLayout();
            flowLayoutPanel_Username.ResumeLayout(false);
            flowLayoutPanel_Username.PerformLayout();
            flowLayoutPanel_APIURL.ResumeLayout(false);
            flowLayoutPanel_APIURL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Discard;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Username;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CSVPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Psw;
        private System.Windows.Forms.TextBox text_Passwd;
        private System.Windows.Forms.TextBox text_Path;
        private System.Windows.Forms.TextBox text_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_APIURL;
        private System.Windows.Forms.TextBox text_API;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Password;
    }
}