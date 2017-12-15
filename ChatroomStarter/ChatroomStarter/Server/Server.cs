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
    public class Server
    {
        public static Client client;
        TcpListener server;
        HashSet<Client> clientList = new HashSet<Client>();
        private Object messageLock = new object();
        // que list of messages;
        public Queue<Message> chatLog = new Queue<Message>();
        public Server(string IP)
        {
            server = new TcpListener(IPAddress.Parse(IP), 9999);
            server.Start();
        }
        public void Run()
        {
            // thread is etc.
   
            // change lambda to make them threads
            Parallel.Invoke(
                () => AcceptClient(),
                () => ReceiveAndRespond()
            );
        }
        public void ReceiveAndRespond()
        {
            lock (messageLock)
            {
                while (true)
                {
                    try
                    {
                        string message = client.Receive();
                        Respond(client, message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        private void AcceptClient()
        {
            while (true)
            {
                TcpClient clientSocket = default(TcpClient);
                Console.WriteLine("Connected");
                clientSocket = server.AcceptTcpClient();
                NetworkStream stream = clientSocket.GetStream();
                client = new Client(stream, clientSocket);
                client.SetUserName();
                clientList.Add(client);                
                Respond(client, client.userName + "has connected to the server");
            }
            //clientSocket.Close();
            //serverSocket.Stop();
            //Console.WriteLine("Exit");
            //Console.ReadLine();
        }
        private void Respond(Client client, string body)
        {
            UpdateChatList(client, body);
            client.Send(chatLog);
        }
        private void UpdateChatList(Client client, string body)
        {
            Message chatAddition = new Message(client, body);
            chatLog.Enqueue(chatAddition);
        }

    }
}
