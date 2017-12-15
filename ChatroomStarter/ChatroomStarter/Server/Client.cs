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
        public string UserId;
        public string userName;
        public Client(NetworkStream Stream, TcpClient Client)
        {
            stream = Stream;
            client = Client;
            UserId = "495933b6-1762-47a1-b655-483510072e73";
                //set userID as user IP address
        }
        public void Send(Queue<Message> chatLog)
        {
            foreach( Message queMessage in chatLog)
            {
                byte[] message = Encoding.ASCII.GetBytes(queMessage.sender.userName + ": " + queMessage.Body);
                stream.Write(message, 0, message.Count());
                //stream.Flush();
            }

        }
        public string Receive()
        {
            byte[] receivedMessage = new byte[256];
            stream.Read(receivedMessage, 0, receivedMessage.Length);
            string receivedMessageString = Encoding.ASCII.GetString(receivedMessage);
            Console.WriteLine(receivedMessageString);
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
