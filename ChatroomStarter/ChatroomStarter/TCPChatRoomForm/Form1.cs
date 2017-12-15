using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using Server;
using System.Net.Sockets;


namespace TCPChatRoomForm
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string sentData = null;
        string userName;

        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Send();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AskName_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   

        }

        private void PromptServor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            // might need to replace Servers.Text
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(Servers.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
        public string Receive()
        {
            while (true)
            {
                byte[] receivedMessage = new byte[256];
                serverStream.Read(receivedMessage, 0, receivedMessage.Length);
                UI.DisplayMessage(Encoding.ASCII.GetString(receivedMessage));
            }
        }
        public void Send()
        {
            while (true)
            {
                byte[] message = Encoding.ASCII.GetBytes(WriteName + ":" + MessageTextBox);
                serverStream.Write(message, 0, message.Count());
            }
            //stream.Flush();
        }
        public void SetClientUserName()
        {
            userName = (WriteName + "");
        }
        public void ConnectToServer()
        {

        }

        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetUserName_Click(object sender, EventArgs e)
        {
            SetClientUserName();
        }
    }
}
