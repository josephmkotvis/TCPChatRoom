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
        List<string> messageLog = new List<string>();
        private Object recievedMessageLock = new object();
        // Maybe create a list of servers premade with the IP address. Either Here or in server class.
        public Form1()
        {
            InitializeComponent();
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

        public string SetIp()
        {
            IP = ServerIPTextBox.Text;
            return IP;
        }
        public void Receive()
        {
            lock (recievedMessageLock)
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
        public void Send()
        {
            while (true)
            {
                byte[] message = Encoding.ASCII.GetBytes(SetNameTextBox + ":" + MessageTextBox);
                serverStream.Write(message, 0, message.Count());
            }
            //stream.Flush();
        }
        public string SetClientUserName()
        {
            userName = (SetNameTextBox.Text);
            return userName;
        }

        private void SetUserName_Click(object sender, EventArgs e)
        {
            SetClientUserName();
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

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            Thread messageSendThread = new Thread(Send);
            messageSendThread.Start();
        }

        private void ServerCheckLabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectServer_Click(object sender, EventArgs e)
        {
            SetIp();
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            serverStream = clientSocket.GetStream();
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
    }
}
