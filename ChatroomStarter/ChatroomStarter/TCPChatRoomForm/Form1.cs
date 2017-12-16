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
        public string UserId;
        public string userName;
        string IP;
        int port = 9999;
        string userMessage = null;
        List<string> messageLog = new List<string>();
        private Object receivedMessageLock = new object();
        Thread MessageReciever;
        // Maybe create a list of servers premade with the IP address. Either Here or in server class.
        public Form1()
        {
            InitializeComponent();
            MessageReciever = new Thread(new ThreadStart(Receive));
            MessageReciever.Start();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void PromptServor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AskUsernamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServerIPTextBox_TextChanged(object sender, EventArgs e)
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
        public string SetIp()
        {
            IP = ServerIPTextBox.Text;
            return IP;
        }
        //public string SetClientUserName()
        //{
        //    userName = (SetNameTextBox.Text);
        //    return userName;
        //}

        private void SetUserName_Click(object sender, EventArgs e)
        {
            SendUserName();
        }
        //private void SetUserName_Click(object sender, EventArgs e)
        //{
        //    SetClientUserName();
        //    Send("*^#UN" + userName);
        //}

        private void SetNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            Send();
        }
        //private string SetUserMessage()
        //{
        //    userMessage = MessageTextBox.Text;
        //    return userMessage;
        //}
        //private string ResetUserMessage()
        //{
        //    userMessage = null;
        //    return userMessage;
        //}
        private void ServerCheckLabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectServer_Click(object sender, EventArgs e)
        {
            SetIp();
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            // change port
            serverStream = clientSocket.GetStream();
        }

        void Receive()
        {
            lock (receivedMessageLock)
            {
                while (true)
                {
                    byte[] receivedMessage = new byte[256];
                    serverStream.Read(receivedMessage, 0, receivedMessage.Length);
                    string receivedMessageString = Encoding.ASCII.GetString(receivedMessage);
                    messageLog.Add(receivedMessageString);
                    MessageBox.DataSource = messageLog;
                }
            }
        }
        //void Send(string userName)
        //{
        //    byte[] message = Encoding.ASCII.GetBytes(userName);
        //    serverStream.Write(message, 0, message.Count());
        //}
        void Send()
        {
            //send username
            //send chatroom
            //message
                byte[] message = Encoding.ASCII.GetBytes(SetNameTextBox + ":" + userMessage);
                serverStream.Write(message, 0, message.Count());
        }
        void SendUserName()
        {
            //send username
            //send chatroom
            //message
            byte[] message = Encoding.ASCII.GetBytes(SetNameTextBox.Text);
            serverStream.Write(message, 0, message.Count());
        }
        //Task RunTasks()
        //{
        //    while (true)
        //    {
        //        Parallel.Invoke(
        //            () => Send(),
        //            () => Receive()
        //            );
        //    }
        //}
    }
}
