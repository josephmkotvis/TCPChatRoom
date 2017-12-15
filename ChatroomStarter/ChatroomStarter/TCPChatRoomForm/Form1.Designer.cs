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
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.ListBox();
            this.OnlineStatuses = new System.Windows.Forms.ListBox();
            this.Servers = new System.Windows.Forms.CheckedListBox();
            this.WriteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AskName = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PromptServor = new System.Windows.Forms.Panel();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.SetUserName = new System.Windows.Forms.Button();
            this.AskName.SuspendLayout();
            this.PromptServor.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(604, 662);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(195, 77);
            this.SendMessageButton.TabIndex = 0;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 662);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(594, 77);
            this.MessageTextBox.TabIndex = 1;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Messages
            // 
            this.Messages.FormattingEnabled = true;
            this.Messages.ItemHeight = 16;
            this.Messages.Location = new System.Drawing.Point(12, 240);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(584, 404);
            this.Messages.TabIndex = 2;
            this.Messages.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // OnlineStatuses
            // 
            this.OnlineStatuses.FormattingEnabled = true;
            this.OnlineStatuses.ItemHeight = 16;
            this.OnlineStatuses.Location = new System.Drawing.Point(612, 240);
            this.OnlineStatuses.Name = "OnlineStatuses";
            this.OnlineStatuses.Size = new System.Drawing.Size(187, 404);
            this.OnlineStatuses.TabIndex = 4;
            this.OnlineStatuses.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Servers
            // 
            this.Servers.FormattingEnabled = true;
            this.Servers.Location = new System.Drawing.Point(383, 16);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(416, 208);
            this.Servers.TabIndex = 5;
            this.Servers.SelectedIndexChanged += new System.EventHandler(this.Servers_SelectedIndexChanged);
            // 
            // WriteName
            // 
            this.WriteName.Location = new System.Drawing.Point(12, 65);
            this.WriteName.Multiline = true;
            this.WriteName.Name = "WriteName";
            this.WriteName.Size = new System.Drawing.Size(261, 52);
            this.WriteName.TabIndex = 6;
            this.WriteName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AskName
            // 
            this.AskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AskName.Controls.Add(this.UsernameLabel);
            this.AskName.Location = new System.Drawing.Point(12, 16);
            this.AskName.Name = "AskName";
            this.AskName.Size = new System.Drawing.Size(356, 43);
            this.AskName.TabIndex = 8;
            this.AskName.Paint += new System.Windows.Forms.PaintEventHandler(this.AskName_Paint);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(101, 11);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(159, 17);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Choose Your Username";
            this.UsernameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PromptServor
            // 
            this.PromptServor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromptServor.Controls.Add(this.ServerLabel);
            this.PromptServor.Location = new System.Drawing.Point(12, 123);
            this.PromptServor.Name = "PromptServor";
            this.PromptServor.Size = new System.Drawing.Size(356, 45);
            this.PromptServor.TabIndex = 9;
            this.PromptServor.Paint += new System.Windows.Forms.PaintEventHandler(this.PromptServor_Paint);
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(71, 10);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(216, 17);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Check Your Server On The Right";
            this.ServerLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 174);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(356, 50);
            this.Connect.TabIndex = 10;
            this.Connect.TabStop = false;
            this.Connect.Text = "Connect To Server";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // SetUserName
            // 
            this.SetUserName.Location = new System.Drawing.Point(270, 65);
            this.SetUserName.Name = "SetUserName";
            this.SetUserName.Size = new System.Drawing.Size(98, 52);
            this.SetUserName.TabIndex = 11;
            this.SetUserName.Text = "Set Name";
            this.SetUserName.UseVisualStyleBackColor = true;
            this.SetUserName.Click += new System.EventHandler(this.SetUserName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 759);
            this.Controls.Add(this.SetUserName);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.WriteName);
            this.Controls.Add(this.PromptServor);
            this.Controls.Add(this.AskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Servers);
            this.Controls.Add(this.OnlineStatuses);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SendMessageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AskName.ResumeLayout(false);
            this.AskName.PerformLayout();
            this.PromptServor.ResumeLayout(false);
            this.PromptServor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.ListBox Messages;
        private System.Windows.Forms.ListBox OnlineStatuses;
        private System.Windows.Forms.CheckedListBox Servers;
        private System.Windows.Forms.TextBox WriteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AskName;
        private System.Windows.Forms.Panel PromptServor;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Button SetUserName;
    }
}

