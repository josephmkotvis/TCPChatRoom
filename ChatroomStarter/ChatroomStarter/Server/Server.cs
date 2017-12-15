using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;      
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        public static Client client;
        TcpListener server;
        HashSet<Client> clientList = new HashSet<Client>();
        private Object messageLock = new object();

        public Server()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9999);
            server.Start();
        }
        public void Run(string userName)
        {
            Parallel.Invoke(
                () => AcceptClient(userName),
                () => RecieveAndRespond(userName)
            );
        }
        public void RecieveAndRespond(string userName)
        {
            lock (messageLock)
            {
                while (true)
                {
                    try
                    {
                        string message = client.Receive();
                        Respond(message, userName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        private void AcceptClient(string userName)
        {
            while (true)
            {
                TcpClient clientSocket = default(TcpClient);
                Console.WriteLine("Connected");
                clientSocket = server.AcceptTcpClient();
                NetworkStream stream = clientSocket.GetStream();
                client = new Client(stream, clientSocket, userName);
                clientList.Add(client);
                Respond(client.userName + "has connected to the server", userName);
            }
            //clientSocket.Close();
            //serverSocket.Stop();
            //Console.WriteLine("Exit");
            //Console.ReadLine();
        }
        private void Respond(string body, string userName)
        {
             client.Send(body,userName);
        }
    }
}
