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
        public int UserId;
        public string userName;
        public bool isOnline;
        public string chatRoom = "general";
        Server server;
        
        public Client(NetworkStream Stream, TcpClient Client, int ID, Server server)
        {
            stream = Stream;
            client = Client;
            this.UserId = ID;
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
            Console.WriteLine(receivedMessage);
            string receivedMessageString = Encoding.ASCII.GetString(receivedMessage);
            return receivedMessageString;
        }
        public void SetUserName()
        {
            byte[] receivedUserName = new byte[256];
            stream.Read(receivedUserName, 0, receivedUserName.Length);
            string receivedUserNameString = Encoding.ASCII.GetString(receivedUserName);
            userName = receivedUserNameString;
        }

    }
}
