namespace TCPChatRoomForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.SetUserName = new System.Windows.Forms.Button();
            this.SetNameTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.AskUsernamePanel = new System.Windows.Forms.Panel();
            this.EnterUsernameLabel = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.ServerCheckLabel = new System.Windows.Forms.Label();
            this.PromptServor = new System.Windows.Forms.Panel();
            this.SelectServer = new System.Windows.Forms.Button();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Server1Info = new System.Windows.Forms.Label();
            this.Server2Info = new System.Windows.Forms.Label();
            this.Server3Info = new System.Windows.Forms.Label();
            this.PrivateServer1Info = new System.Windows.Forms.Label();
            this.PrivateServer2Info = new System.Windows.Forms.Label();
            this.PrivateServer3Info = new System.Windows.Forms.Label();
            this.AskUsernamePanel.SuspendLayout();
            this.PromptServor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            // 
            // SetUserName
            // 
            this.SetUserName.Location = new System.Drawing.Point(501, 65);
            this.SetUserName.Name = "SetUserName";
            this.SetUserName.Size = new System.Drawing.Size(98, 52);
            this.SetUserName.TabIndex = 11;
            this.SetUserName.Text = "Set Name";
            this.SetUserName.UseVisualStyleBackColor = true;
            this.SetUserName.Click += new System.EventHandler(this.SetUserName_Click);
            // 
            // SetNameTextBox
            // 
            this.SetNameTextBox.Location = new System.Drawing.Point(12, 65);
            this.SetNameTextBox.Multiline = true;
            this.SetNameTextBox.Name = "SetNameTextBox";
            this.SetNameTextBox.Size = new System.Drawing.Size(493, 52);
            this.SetNameTextBox.TabIndex = 12;
            this.SetNameTextBox.TextChanged += new System.EventHandler(this.SetNameTextBox_TextChanged);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(15, 662);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(594, 77);
            this.MessageTextBox.TabIndex = 15;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // AskUsernamePanel
            // 
            this.AskUsernamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AskUsernamePanel.Controls.Add(this.EnterUsernameLabel);
            this.AskUsernamePanel.Location = new System.Drawing.Point(12, 12);
            this.AskUsernamePanel.Name = "AskUsernamePanel";
            this.AskUsernamePanel.Size = new System.Drawing.Size(587, 47);
            this.AskUsernamePanel.TabIndex = 16;
            this.AskUsernamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AskUsernamePanel_Paint);
            // 
            // EnterUsernameLabel
            // 
            this.EnterUsernameLabel.AutoSize = true;
            this.EnterUsernameLabel.Enabled = false;
            this.EnterUsernameLabel.Location = new System.Drawing.Point(220, 14);
            this.EnterUsernameLabel.Name = "EnterUsernameLabel";
            this.EnterUsernameLabel.Size = new System.Drawing.Size(145, 17);
            this.EnterUsernameLabel.TabIndex = 0;
            this.EnterUsernameLabel.Text = "Enter Your Username";
            this.EnterUsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EnterUsernameLabel.Click += new System.EventHandler(this.EnterUsernameLabel_Click);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(603, 662);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(196, 77);
            this.SendMessageButton.TabIndex = 17;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // ServerCheckLabel
            // 
            this.ServerCheckLabel.AutoSize = true;
            this.ServerCheckLabel.Location = new System.Drawing.Point(178, 11);
            this.ServerCheckLabel.Name = "ServerCheckLabel";
            this.ServerCheckLabel.Size = new System.Drawing.Size(216, 17);
            this.ServerCheckLabel.TabIndex = 0;
            this.ServerCheckLabel.Text = "Check Your Server On The Right";
            this.ServerCheckLabel.Click += new System.EventHandler(this.ServerCheckLabel_Click);
            // 
            // PromptServor
            // 
            this.PromptServor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromptServor.Controls.Add(this.ServerCheckLabel);
            this.PromptServor.Location = new System.Drawing.Point(12, 123);
            this.PromptServor.Name = "PromptServor";
            this.PromptServor.Size = new System.Drawing.Size(587, 45);
            this.PromptServor.TabIndex = 9;
            this.PromptServor.Paint += new System.Windows.Forms.PaintEventHandler(this.PromptServor_Paint);
            // 
            // SelectServer
            // 
            this.SelectServer.Location = new System.Drawing.Point(501, 174);
            this.SelectServer.Name = "SelectServer";
            this.SelectServer.Size = new System.Drawing.Size(98, 50);
            this.SelectServer.TabIndex = 21;
            this.SelectServer.Text = "Submit Server IP";
            this.SelectServer.UseVisualStyleBackColor = true;
            this.SelectServer.Click += new System.EventHandler(this.SelectServer_Click);
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Location = new System.Drawing.Point(12, 174);
            this.ServerIPTextBox.Multiline = true;
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(493, 49);
            this.ServerIPTextBox.TabIndex = 22;
            this.ServerIPTextBox.TextChanged += new System.EventHandler(this.ServerIPTextBox_TextChanged);
            // 
            // MessageBox
            // 
            this.MessageBox.FormattingEnabled = true;
            this.MessageBox.ItemHeight = 16;
            this.MessageBox.Location = new System.Drawing.Point(12, 229);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(587, 420);
            this.MessageBox.TabIndex = 23;
            this.MessageBox.SelectedIndexChanged += new System.EventHandler(this.MessageBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PrivateServer3Info);
            this.panel1.Controls.Add(this.PrivateServer2Info);
            this.panel1.Controls.Add(this.PrivateServer1Info);
            this.panel1.Controls.Add(this.Server3Info);
            this.panel1.Controls.Add(this.Server2Info);
            this.panel1.Controls.Add(this.Server1Info);
            this.panel1.Location = new System.Drawing.Point(606, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 208);
            this.panel1.TabIndex = 24;
            // 
            // Server1Info
            // 
            this.Server1Info.AutoSize = true;
            this.Server1Info.Location = new System.Drawing.Point(3, 12);
            this.Server1Info.Name = "Server1Info";
            this.Server1Info.Size = new System.Drawing.Size(158, 17);
            this.Server1Info.TabIndex = 0;
            this.Server1Info.Text = "Room1 - 192.168.0.135";
            this.Server1Info.Click += new System.EventHandler(this.Server1Info_Click);
            // 
            // Server2Info
            // 
            this.Server2Info.AutoSize = true;
            this.Server2Info.Location = new System.Drawing.Point(3, 50);
            this.Server2Info.Name = "Server2Info";
            this.Server2Info.Size = new System.Drawing.Size(62, 17);
            this.Server2Info.TabIndex = 1;
            this.Server2Info.Text = "Room2 -";
            this.Server2Info.Click += new System.EventHandler(this.Server2Info_Click);
            // 
            // Server3Info
            // 
            this.Server3Info.AutoSize = true;
            this.Server3Info.Location = new System.Drawing.Point(3, 85);
            this.Server3Info.Name = "Server3Info";
            this.Server3Info.Size = new System.Drawing.Size(62, 17);
            this.Server3Info.TabIndex = 2;
            this.Server3Info.Text = "Room3 -";
            // 
            // PrivateServer1Info
            // 
            this.PrivateServer1Info.AutoSize = true;
            this.PrivateServer1Info.Location = new System.Drawing.Point(3, 120);
            this.PrivateServer1Info.Name = "PrivateServer1Info";
            this.PrivateServer1Info.Size = new System.Drawing.Size(106, 17);
            this.PrivateServer1Info.TabIndex = 3;
            this.PrivateServer1Info.Text = "Privat Room 1 -";
            // 
            // PrivateServer2Info
            // 
            this.PrivateServer2Info.AutoSize = true;
            this.PrivateServer2Info.Location = new System.Drawing.Point(3, 150);
            this.PrivateServer2Info.Name = "PrivateServer2Info";
            this.PrivateServer2Info.Size = new System.Drawing.Size(106, 17);
            this.PrivateServer2Info.TabIndex = 4;
            this.PrivateServer2Info.Text = "Privat Room 2 -";
            // 
            // PrivateServer3Info
            // 
            this.PrivateServer3Info.AutoSize = true;
            this.PrivateServer3Info.Location = new System.Drawing.Point(3, 176);
            this.PrivateServer3Info.Name = "PrivateServer3Info";
            this.PrivateServer3Info.Size = new System.Drawing.Size(106, 17);
            this.PrivateServer3Info.TabIndex = 5;
            this.PrivateServer3Info.Text = "Privat Room 3 -";
            this.PrivateServer3Info.Click += new System.EventHandler(this.PrivateServer3Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.SelectServer);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.AskUsernamePanel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SetNameTextBox);
            this.Controls.Add(this.SetUserName);
            this.Controls.Add(this.PromptServor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AskUsernamePanel.ResumeLayout(false);
            this.AskUsernamePanel.PerformLayout();
            this.PromptServor.ResumeLayout(false);
            this.PromptServor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetUserName;
        private System.Windows.Forms.TextBox SetNameTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Panel AskUsernamePanel;
        private System.Windows.Forms.Label EnterUsernameLabel;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label ServerCheckLabel;
        private System.Windows.Forms.Panel PromptServor;
        private System.Windows.Forms.Button SelectServer;
        private System.Windows.Forms.TextBox ServerIPTextBox;
        private System.Windows.Forms.ListBox MessageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Server2Info;
        private System.Windows.Forms.Label Server1Info;
        private System.Windows.Forms.Label PrivateServer3Info;
        private System.Windows.Forms.Label PrivateServer2Info;
        private System.Windows.Forms.Label PrivateServer1Info;
        private System.Windows.Forms.Label Server3Info;
    }
}

