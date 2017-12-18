using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client
    {
        NetworkStream stream;
        public TcpClient client;
        public int userId;
        public string userName;
        public bool isOnline;
        public string chatRoom;
        Server server;
        
        public Client(NetworkStream Stream, TcpClient Client, int ID, Server server)
        {
            stream = Stream;
            client = Client;
            this.userId = ID;
            this.server = server;
        }
        public void Send(Message broadCast)
        {
            byte[] message = Encoding.ASCII.GetBytes(broadCast.sender.userName + ": " + broadCast.Body + Environment.NewLine);
            stream.Write(message, 0, message.Count());
        }
        public Message Receive()
        {
                byte[] receivedMessage = new byte[256];
                stream.Read(receivedMessage, 0, receivedMessage.Length);
                string receivedMessageString = Encoding.ASCII.GetString(RemoveZerozInMessage(receivedMessage));
                Message checkedMessage = CheckMessage(receivedMessageString);
                return checkedMessage;
        }
        private Message CheckMessage(string message)
        {
            if (message.StartsWith("*^CR"))
            {
                Message leftMessage = new Message(this, "has left the chatroom " + chatRoom +"." + Environment.NewLine);
                server.chatLog.Enqueue(leftMessage);
                SetChatRoom(message);
                Message joinMessage = new Message(this, "has joined the chatroom " + chatRoom +"."  +Environment.NewLine);
                return joinMessage;
            }
            else if (message.StartsWith("*^UN"))
            {
                string oldName = userName;
                userName = message.Substring(4);
                Message namechangedMessage = new Message(this, "has changed name from " + oldName + " to " + userName + "." + Environment.NewLine);
                return namechangedMessage;
            }
            else if (message.StartsWith("*^LO"))
            {
                Message clientRemoved = new Message(this, "*^LON"); 
                return clientRemoved;
            }
            else
            {
                Message sentMessage = new Message(this, message + Environment.NewLine);
                return sentMessage;
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
        public void SetChatRoom(string message)
        {
            chatRoom = message.Substring(4);
        }
    }
}
