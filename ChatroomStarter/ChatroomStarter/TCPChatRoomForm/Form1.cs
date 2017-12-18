using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
using System.Net.Sockets;
using System.Net;


namespace TCPChatRoomForm
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream;
        string defaultUserName;
        string defaultChatRoom;
        string IP = "127.0.0.1";
        int port = 9999;
        List<string> messageLog = new List<string>();
        private Object receivedMessageLock = new object();
        Thread MessageReciever;
        public Form1()
        {
            InitializeComponent();
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            serverStream = clientSocket.GetStream();
            MessageReciever = new Thread(new ThreadStart(Receive));
            defaultUserName = "NewUser";
            defaultChatRoom = "General";
            MessageReciever.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeChatRoom();
        }
        private void InitializeChatRoom()
        {
            SetNameTextBox.Text = defaultUserName;
            SendUserName();
            ChatRoomName.Text = defaultChatRoom;
            SendChatRoom();
        }
       
        private void SetUserName_Click(object sender, EventArgs e)
        {
            SendUserName();
        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            Send();
        }
        void Receive()
        {
            lock (receivedMessageLock)
            {
                while (true)
                {
                    try
                    {
                        byte[] receivedMessage = new byte[256];
                        serverStream.Read(receivedMessage, 0, receivedMessage.Length);
                        string receivedMessageString = Encoding.ASCII.GetString(receivedMessage);
                        ChatTextBox.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { ChatTextBox.AppendText(receivedMessageString); });
                        CurrentUserName.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { CurrentUserName.Clear(); });
                        CurrentChatRoom.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { CurrentChatRoom.Clear(); });
                        CurrentUserName.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { CurrentUserName.AppendText("Current User Name: " + SetNameTextBox.Text + "."); });
                        CurrentChatRoom.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { CurrentChatRoom.AppendText("Current Chat Room: " + ChatRoomName.Text + "."); });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        void Send()
        {
            byte[] message = Encoding.ASCII.GetBytes( MessageTextBox.Text);
            serverStream.Write(message, 0, message.Count());
        }
        void SendUserName()
        {

            byte[] message = Encoding.ASCII.GetBytes("*^UN" + SetNameTextBox.Text);
           serverStream.Write(message, 0, message.Count());
        }
        void SendChatRoom()
        {
            byte[] message = Encoding.ASCII.GetBytes("*^CR" + ChatRoomName.Text);
            serverStream.Write(message, 0, message.Count());
            CheckChatRoomList();
        }
        void SendLogOff()
        {
            byte[] message = Encoding.ASCII.GetBytes("*^LO" + SetNameTextBox.Text);
            serverStream.Write(message, 0, message.Count());
        }
        void CheckChatRoomList()
        {
            foreach(string ChatRoom in ChatroomList.Items)
            {
                if (ChatRoomName.Text == ChatRoom)
                {

                        ChatroomList.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { ChatroomList.Items.Remove(ChatRoomName.Text); });
                }
            }
            ChatroomList.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { ChatroomList.Items.Add(ChatRoomName.Text); });
        }
        private void SetCreateRoom_Click(object sender, EventArgs e)
        {
            SendChatRoom();
        }
        private void ChatroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChatRoomName.Text = (ChatroomList.SelectedItem.ToString());
                SendChatRoom();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private byte[] RemoveZerozInMessage(byte[] message)
        {
            int i = message.Length - 1;
            while (message[i] == 0)
            {
                --i;
            }
            byte[] CleanMessage = new byte[i + 1];
            Array.Copy(message, CleanMessage, i + 1);
            return CleanMessage;
        }
        private void LogOff_Click(object sender, EventArgs e)
        {
            SendLogOff();
            Close();
        }
        private void ChatTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ChatRoomName_TextChanged(object sender, EventArgs e)
        {

        }
        private void CurrentChatRoom_TextChanged(object sender, EventArgs e)
        {

        }
        private void CurrentUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void PromptServor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AskUsernamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ChatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MessageBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Server1Info_Click(object sender, EventArgs e)
        {

        }
        private void Server2Info_Click(object sender, EventArgs e)
        {

        }
        private void PrivateServer3Info_Click(object sender, EventArgs e)
        {

        }
        private void SetNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void EnterUsernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
