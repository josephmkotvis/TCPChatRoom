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
            this.PromptServor = new System.Windows.Forms.Panel();
            this.AskChatRoom = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.ListBox();
            this.ChatRoomName = new System.Windows.Forms.TextBox();
            this.SetCreateRoom = new System.Windows.Forms.Button();
            this.ChatroomList = new System.Windows.Forms.ListBox();
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
            this.EnterUsernameLabel.Location = new System.Drawing.Point(205, 14);
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
            // PromptServor
            // 
            this.PromptServor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromptServor.Controls.Add(this.AskChatRoom);
            this.PromptServor.Location = new System.Drawing.Point(12, 123);
            this.PromptServor.Name = "PromptServor";
            this.PromptServor.Size = new System.Drawing.Size(587, 45);
            this.PromptServor.TabIndex = 9;
            this.PromptServor.Paint += new System.Windows.Forms.PaintEventHandler(this.PromptServor_Paint);
            // 
            // AskChatRoom
            // 
            this.AskChatRoom.AutoSize = true;
            this.AskChatRoom.Location = new System.Drawing.Point(142, 11);
            this.AskChatRoom.Name = "AskChatRoom";
            this.AskChatRoom.Size = new System.Drawing.Size(299, 17);
            this.AskChatRoom.TabIndex = 0;
            this.AskChatRoom.Text = "Enter The Chat Room You Would Like To Join";
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
            // ChatRoomName
            // 
            this.ChatRoomName.Location = new System.Drawing.Point(12, 174);
            this.ChatRoomName.Multiline = true;
            this.ChatRoomName.Name = "ChatRoomName";
            this.ChatRoomName.Size = new System.Drawing.Size(493, 49);
            this.ChatRoomName.TabIndex = 27;
            // 
            // SetCreateRoom
            // 
            this.SetCreateRoom.Location = new System.Drawing.Point(501, 174);
            this.SetCreateRoom.Name = "SetCreateRoom";
            this.SetCreateRoom.Size = new System.Drawing.Size(98, 52);
            this.SetCreateRoom.TabIndex = 28;
            this.SetCreateRoom.Text = "Set/Create Room";
            this.SetCreateRoom.UseVisualStyleBackColor = true;
            this.SetCreateRoom.Click += new System.EventHandler(this.SetCreateRoom_Click);
            // 
            // ChatroomList
            // 
            this.ChatroomList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatroomList.FormattingEnabled = true;
            this.ChatroomList.ItemHeight = 16;
            this.ChatroomList.Location = new System.Drawing.Point(615, 12);
            this.ChatroomList.Name = "ChatroomList";
            this.ChatroomList.Size = new System.Drawing.Size(184, 628);
            this.ChatroomList.TabIndex = 29;
            this.ChatroomList.SelectedIndexChanged += new System.EventHandler(this.ChatroomList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 771);
            this.Controls.Add(this.ChatroomList);
            this.Controls.Add(this.SetCreateRoom);
            this.Controls.Add(this.ChatRoomName);
            this.Controls.Add(this.MessageBox);
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
        private System.Windows.Forms.Panel PromptServor;
        private System.Windows.Forms.ListBox MessageBox;
        private System.Windows.Forms.Label AskChatRoom;
        private System.Windows.Forms.TextBox ChatRoomName;
        private System.Windows.Forms.Button SetCreateRoom;
        private System.Windows.Forms.ListBox ChatroomList;
    }
}

