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
        TcpClient client;
        public int userId;
        public string userName;
        public bool isOnline;
        public string chatRoom = "general";
        Server server;
        
        public Client(NetworkStream Stream, TcpClient Client, int ID, Server server)
        {
            stream = Stream;
            client = Client;
            this.userId = ID;
            this.server = server;
            //set userID as user IP address
            //this.chatRoom = chatRoom;
        }
        public void Send(Message broadCast)
        {
            byte[] message = Encoding.ASCII.GetBytes(broadCast.sender.userName + ": " + broadCast.Body);
            stream.Write(message, 0, message.Count());
                //stream.Flush();
        }
        public string Receive()
        {
            byte[] receivedMessage = new byte[256];
            stream.Read(receivedMessage, 0, receivedMessage.Length);
            string receivedMessageString = Encoding.ASCII.GetString(CleanMessage(receivedMessage));
            return receivedMessageString;
        }
        public void SetUserName()
        {
            byte[] receivedUserName = new byte[256];
            stream.Read(receivedUserName, 0, receivedUserName.Length);
            string receivedUserNameString = Encoding.ASCII.GetString(CleanMessage(receivedUserName));
            userName = receivedUserNameString;
            Console.WriteLine("User " + userId + " has set their user name to " + userName);
        }
        private byte[] CleanMessage(byte[] message)
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
            Console.WriteLine(userName + " has set their chat room to " + chatRoom);
        }

    }
}
