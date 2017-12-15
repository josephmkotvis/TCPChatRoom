using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        TcpClient clientSocket;
        NetworkStream stream;
        public string UserId;
        public Client(string IP, int port)
        {
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            stream = clientSocket.GetStream();
        }
        public void Create()
        {
            Client client = new Client("127.0.0.1", 9999);
        }
        public void Send()
        {
            string messageString = UI.GetInput();
            byte[] message = Encoding.ASCII.GetBytes(messageString);
            stream.Write(message, 0, message.Count());
            // Console.WriteLine("Sent: {0}", message);
        }
        public void Receive()
        {
            byte[] receivedMessage = new byte[256];
            stream.Read(receivedMessage, 0, receivedMessage.Length);
            UI.DisplayMessage(Encoding.ASCII.GetString(receivedMessage));
            // receivedMessageString = System.Test.Encoding.ASCII.GetString( data, 0 , bytes);
            // Console.WriteLine("Recieved: {0}", rereviewedMessageString);
            // return receivedMessageString;
        }
    }
}
