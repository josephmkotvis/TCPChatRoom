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
            this.ChatBox = new System.Windows.Forms.ListView();
            this.ServerCheckLabel = new System.Windows.Forms.Label();
            this.PromptServor = new System.Windows.Forms.Panel();
            this.SelectServer = new System.Windows.Forms.Button();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.AskUsernamePanel.SuspendLayout();
            this.PromptServor.SuspendLayout();
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
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(12, 230);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(587, 418);
            this.ChatBox.TabIndex = 19;
            this.ChatBox.UseCompatibleStateImageBehavior = false;
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
            this.ServerIPTextBox.Location = new System.Drawing.Point(17, 174);
            this.ServerIPTextBox.Multiline = true;
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(484, 49);
            this.ServerIPTextBox.TabIndex = 22;
            this.ServerIPTextBox.TextChanged += new System.EventHandler(this.ServerIPTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 771);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.SelectServer);
            this.Controls.Add(this.ChatBox);
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
        private System.Windows.Forms.ListView ChatBox;
        private System.Windows.Forms.Label ServerCheckLabel;
        private System.Windows.Forms.Panel PromptServor;
        private System.Windows.Forms.Button SelectServer;
        private System.Windows.Forms.TextBox ServerIPTextBox;
    }
}

