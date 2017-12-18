namespace TCPChatRoomForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.PromptServor = new System.Windows.Forms.Panel();
            this.AskChatRoom = new System.Windows.Forms.Label();
            this.ChatRoomName = new System.Windows.Forms.TextBox();
            this.SetCreateRoom = new System.Windows.Forms.Button();
            this.ChatroomList = new System.Windows.Forms.ListBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.EnterUsernameLabel = new System.Windows.Forms.Label();
            this.LogOff = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CurrentUserName = new System.Windows.Forms.TextBox();
            this.CurrentChatRoom = new System.Windows.Forms.TextBox();
            this.AskUsernamePanel.SuspendLayout();
            this.PromptServor.SuspendLayout();
            this.Info.SuspendLayout();
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
            this.SetUserName.Location = new System.Drawing.Point(511, 12);
            this.SetUserName.Name = "SetUserName";
            this.SetUserName.Size = new System.Drawing.Size(111, 52);
            this.SetUserName.TabIndex = 11;
            this.SetUserName.Text = "Set Name";
            this.SetUserName.UseVisualStyleBackColor = true;
            this.SetUserName.Click += new System.EventHandler(this.SetUserName_Click);
            // 
            // SetNameTextBox
            // 
            this.SetNameTextBox.Location = new System.Drawing.Point(8, 42);
            this.SetNameTextBox.Name = "SetNameTextBox";
            this.SetNameTextBox.Size = new System.Drawing.Size(497, 22);
            this.SetNameTextBox.TabIndex = 12;
            this.SetNameTextBox.TextChanged += new System.EventHandler(this.SetNameTextBox_TextChanged);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(8, 600);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(497, 63);
            this.MessageTextBox.TabIndex = 15;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // AskUsernamePanel
            // 
            this.AskUsernamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AskUsernamePanel.Controls.Add(this.EnterUsernameLabel);
            this.AskUsernamePanel.Location = new System.Drawing.Point(8, 12);
            this.AskUsernamePanel.Name = "AskUsernamePanel";
            this.AskUsernamePanel.Size = new System.Drawing.Size(497, 30);
            this.AskUsernamePanel.TabIndex = 16;
            this.AskUsernamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AskUsernamePanel_Paint);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(511, 600);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(111, 63);
            this.SendMessageButton.TabIndex = 17;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // PromptServor
            // 
            this.PromptServor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromptServor.Controls.Add(this.AskChatRoom);
            this.PromptServor.Location = new System.Drawing.Point(8, 72);
            this.PromptServor.Name = "PromptServor";
            this.PromptServor.Size = new System.Drawing.Size(497, 30);
            this.PromptServor.TabIndex = 9;
            this.PromptServor.Paint += new System.Windows.Forms.PaintEventHandler(this.PromptServor_Paint);
            // 
            // AskChatRoom
            // 
            this.AskChatRoom.AutoSize = true;
            this.AskChatRoom.Location = new System.Drawing.Point(104, 5);
            this.AskChatRoom.Name = "AskChatRoom";
            this.AskChatRoom.Size = new System.Drawing.Size(299, 17);
            this.AskChatRoom.TabIndex = 0;
            this.AskChatRoom.Text = "Enter The Chat Room You Would Like To Join";
            // 
            // ChatRoomName
            // 
            this.ChatRoomName.Location = new System.Drawing.Point(8, 102);
            this.ChatRoomName.Name = "ChatRoomName";
            this.ChatRoomName.Size = new System.Drawing.Size(497, 22);
            this.ChatRoomName.TabIndex = 27;
            this.ChatRoomName.TextChanged += new System.EventHandler(this.ChatRoomName_TextChanged);
            // 
            // SetCreateRoom
            // 
            this.SetCreateRoom.Location = new System.Drawing.Point(511, 70);
            this.SetCreateRoom.Name = "SetCreateRoom";
            this.SetCreateRoom.Size = new System.Drawing.Size(111, 52);
            this.SetCreateRoom.TabIndex = 28;
            this.SetCreateRoom.Text = "Set/Create Room";
            this.SetCreateRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SetCreateRoom.UseVisualStyleBackColor = true;
            this.SetCreateRoom.Click += new System.EventHandler(this.SetCreateRoom_Click);
            // 
            // ChatroomList
            // 
            this.ChatroomList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatroomList.FormattingEnabled = true;
            this.ChatroomList.ItemHeight = 16;
            this.ChatroomList.Location = new System.Drawing.Point(511, 190);
            this.ChatroomList.Name = "ChatroomList";
            this.ChatroomList.Size = new System.Drawing.Size(111, 404);
            this.ChatroomList.TabIndex = 29;
            this.ChatroomList.SelectedIndexChanged += new System.EventHandler(this.ChatroomList_SelectedIndexChanged);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChatTextBox.Location = new System.Drawing.Point(8, 190);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.Size = new System.Drawing.Size(497, 404);
            this.ChatTextBox.TabIndex = 30;
            this.ChatTextBox.UseSystemPasswordChar = true;
            this.ChatTextBox.TextChanged += new System.EventHandler(this.ChatTextBox_TextChanged);
            // 
            // EnterUsernameLabel
            // 
            this.EnterUsernameLabel.AutoSize = true;
            this.EnterUsernameLabel.Location = new System.Drawing.Point(164, 6);
            this.EnterUsernameLabel.Name = "EnterUsernameLabel";
            this.EnterUsernameLabel.Size = new System.Drawing.Size(145, 17);
            this.EnterUsernameLabel.TabIndex = 1;
            this.EnterUsernameLabel.Text = "Enter Your Username";
            // 
            // LogOff
            // 
            this.LogOff.CausesValidation = false;
            this.LogOff.Location = new System.Drawing.Point(511, 132);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(111, 52);
            this.LogOff.TabIndex = 32;
            this.LogOff.Text = "Log Off";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // Info
            // 
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info.Controls.Add(this.InfoLabel);
            this.Info.Location = new System.Drawing.Point(8, 132);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(497, 30);
            this.Info.TabIndex = 33;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(160, 5);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(163, 17);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Your Current Information";
            // 
            // CurrentUserName
            // 
            this.CurrentUserName.Location = new System.Drawing.Point(8, 162);
            this.CurrentUserName.Name = "CurrentUserName";
            this.CurrentUserName.Size = new System.Drawing.Size(246, 22);
            this.CurrentUserName.TabIndex = 34;
            this.CurrentUserName.TextChanged += new System.EventHandler(this.CurrentUserName_TextChanged);
            // 
            // CurrentChatRoom
            // 
            this.CurrentChatRoom.Location = new System.Drawing.Point(253, 162);
            this.CurrentChatRoom.Name = "CurrentChatRoom";
            this.CurrentChatRoom.Size = new System.Drawing.Size(252, 22);
            this.CurrentChatRoom.TabIndex = 35;
            this.CurrentChatRoom.TextChanged += new System.EventHandler(this.CurrentChatRoom_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 670);
            this.Controls.Add(this.CurrentChatRoom);
            this.Controls.Add(this.CurrentUserName);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.ChatroomList);
            this.Controls.Add(this.ChatRoomName);
            this.Controls.Add(this.AskUsernamePanel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SetNameTextBox);
            this.Controls.Add(this.PromptServor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetUserName);
            this.Controls.Add(this.SetCreateRoom);
            this.Controls.Add(this.SendMessageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AskUsernamePanel.ResumeLayout(false);
            this.AskUsernamePanel.PerformLayout();
            this.PromptServor.ResumeLayout(false);
            this.PromptServor.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetUserName;
        private System.Windows.Forms.TextBox SetNameTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Panel AskUsernamePanel;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Panel PromptServor;
        private System.Windows.Forms.Label AskChatRoom;
        private System.Windows.Forms.TextBox ChatRoomName;
        private System.Windows.Forms.Button SetCreateRoom;
        private System.Windows.Forms.ListBox ChatroomList;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.Label EnterUsernameLabel;
        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox CurrentUserName;
        private System.Windows.Forms.TextBox CurrentChatRoom;
    }
}

