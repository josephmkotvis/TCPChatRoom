namespace TCPServerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrivateServer3Info = new System.Windows.Forms.Label();
            this.PrivateServer2Info = new System.Windows.Forms.Label();
            this.PrivateServer1Info = new System.Windows.Forms.Label();
            this.Server3Info = new System.Windows.Forms.Label();
            this.Server2Info = new System.Windows.Forms.Label();
            this.Server1Info = new System.Windows.Forms.Label();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.SelectServer = new System.Windows.Forms.Button();
            this.PromptServor = new System.Windows.Forms.Panel();
            this.ServerCheckLabel = new System.Windows.Forms.Label();
            this.SetUserName = new System.Windows.Forms.Button();
            this.SetNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterUsernameLabel = new System.Windows.Forms.Label();
            this.AskUsernamePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PromptServor.SuspendLayout();
            this.AskUsernamePanel.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 32;
            // 
            // PrivateServer3Info
            // 
            this.PrivateServer3Info.AutoSize = true;
            this.PrivateServer3Info.Location = new System.Drawing.Point(3, 176);
            this.PrivateServer3Info.Name = "PrivateServer3Info";
            this.PrivateServer3Info.Size = new System.Drawing.Size(106, 17);
            this.PrivateServer3Info.TabIndex = 5;
            this.PrivateServer3Info.Text = "Privat Room 3 -";
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
            // PrivateServer1Info
            // 
            this.PrivateServer1Info.AutoSize = true;
            this.PrivateServer1Info.Location = new System.Drawing.Point(3, 120);
            this.PrivateServer1Info.Name = "PrivateServer1Info";
            this.PrivateServer1Info.Size = new System.Drawing.Size(106, 17);
            this.PrivateServer1Info.TabIndex = 3;
            this.PrivateServer1Info.Text = "Privat Room 1 -";
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
            // Server2Info
            // 
            this.Server2Info.AutoSize = true;
            this.Server2Info.Location = new System.Drawing.Point(3, 50);
            this.Server2Info.Name = "Server2Info";
            this.Server2Info.Size = new System.Drawing.Size(62, 17);
            this.Server2Info.TabIndex = 1;
            this.Server2Info.Text = "Room2 -";
            // 
            // Server1Info
            // 
            this.Server1Info.AutoSize = true;
            this.Server1Info.Location = new System.Drawing.Point(3, 12);
            this.Server1Info.Name = "Server1Info";
            this.Server1Info.Size = new System.Drawing.Size(126, 17);
            this.Server1Info.TabIndex = 0;
            this.Server1Info.Text = "Room1 - 127.0.0.1";
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Location = new System.Drawing.Point(12, 65);
            this.ServerIPTextBox.Multiline = true;
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(493, 49);
            this.ServerIPTextBox.TabIndex = 31;
            // 
            // SelectServer
            // 
            this.SelectServer.Location = new System.Drawing.Point(501, 65);
            this.SelectServer.Name = "SelectServer";
            this.SelectServer.Size = new System.Drawing.Size(98, 50);
            this.SelectServer.TabIndex = 30;
            this.SelectServer.Text = "Submit Server IP";
            this.SelectServer.UseVisualStyleBackColor = true;
            // 
            // PromptServor
            // 
            this.PromptServor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromptServor.Controls.Add(this.ServerCheckLabel);
            this.PromptServor.Location = new System.Drawing.Point(12, 14);
            this.PromptServor.Name = "PromptServor";
            this.PromptServor.Size = new System.Drawing.Size(587, 45);
            this.PromptServor.TabIndex = 25;
            // 
            // ServerCheckLabel
            // 
            this.ServerCheckLabel.AutoSize = true;
            this.ServerCheckLabel.Location = new System.Drawing.Point(178, 11);
            this.ServerCheckLabel.Name = "ServerCheckLabel";
            this.ServerCheckLabel.Size = new System.Drawing.Size(216, 17);
            this.ServerCheckLabel.TabIndex = 0;
            this.ServerCheckLabel.Text = "Check Your Server On The Right";
            // 
            // SetUserName
            // 
            this.SetUserName.Location = new System.Drawing.Point(501, 174);
            this.SetUserName.Name = "SetUserName";
            this.SetUserName.Size = new System.Drawing.Size(98, 52);
            this.SetUserName.TabIndex = 26;
            this.SetUserName.Text = "Set Name";
            this.SetUserName.UseVisualStyleBackColor = true;
            // 
            // SetNameTextBox
            // 
            this.SetNameTextBox.Location = new System.Drawing.Point(12, 174);
            this.SetNameTextBox.Multiline = true;
            this.SetNameTextBox.Name = "SetNameTextBox";
            this.SetNameTextBox.Size = new System.Drawing.Size(493, 52);
            this.SetNameTextBox.TabIndex = 27;
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
            // 
            // AskUsernamePanel
            // 
            this.AskUsernamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AskUsernamePanel.Controls.Add(this.EnterUsernameLabel);
            this.AskUsernamePanel.Location = new System.Drawing.Point(12, 121);
            this.AskUsernamePanel.Name = "AskUsernamePanel";
            this.AskUsernamePanel.Size = new System.Drawing.Size(587, 47);
            this.AskUsernamePanel.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.SelectServer);
            this.Controls.Add(this.AskUsernamePanel);
            this.Controls.Add(this.SetNameTextBox);
            this.Controls.Add(this.SetUserName);
            this.Controls.Add(this.PromptServor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PromptServor.ResumeLayout(false);
            this.PromptServor.PerformLayout();
            this.AskUsernamePanel.ResumeLayout(false);
            this.AskUsernamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PrivateServer3Info;
        private System.Windows.Forms.Label PrivateServer2Info;
        private System.Windows.Forms.Label PrivateServer1Info;
        private System.Windows.Forms.Label Server3Info;
        private System.Windows.Forms.Label Server2Info;
        private System.Windows.Forms.Label Server1Info;
        private System.Windows.Forms.TextBox ServerIPTextBox;
        private System.Windows.Forms.Button SelectServer;
        private System.Windows.Forms.Panel PromptServor;
        private System.Windows.Forms.Label ServerCheckLabel;
        private System.Windows.Forms.Button SetUserName;
        private System.Windows.Forms.TextBox SetNameTextBox;
        private System.Windows.Forms.Label EnterUsernameLabel;
        private System.Windows.Forms.Panel AskUsernamePanel;
    }
}

