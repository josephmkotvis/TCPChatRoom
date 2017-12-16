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
        public Client client;
        TcpListener server;
        HashSet<Client> clientList;
        public Queue<Message> chatLog;
        Object messageLock;
        Object clientListLock;
        Thread ClientAcceptor;
        Thread MessageReceiver;
        Thread MessageBroadcaster;
        //List<Queue<String[Message]
        // list of ques
        public Server(string IP)
        {
            server = new TcpListener(IPAddress.Parse(IP), 9999);
            clientList = new HashSet<Client>();
            chatLog = new Queue<Message>();
            messageLock = new Object();
            clientListLock = new Object();
            server.Start();
        }
        public void Run()
        {
            ClientAcceptor = new Thread(new ThreadStart(AcceptClient));
            ClientAcceptor.Start();
            MessageBroadcaster = new Thread(new ThreadStart(Broadcast));
            MessageBroadcaster.Start();
        }

        public void ReceiveAndRespond(Client client)
        {
            while (true)
            {
                // match chatroom
                lock (messageLock)
                {
                    try
                    {
                        string message = client.Receive();
                        Console.WriteLine(message);
                        Respond(client, message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        private void Broadcast()
        {
            while (true)
            {
                lock (messageLock)
                {
                    if (chatLog.Count > 0)
                    {
                        Message message = chatLog.Dequeue();
                        SendMessagesToClients(message);

                    }
                }
            }
        }
        private void AcceptClient()
        {
            int userID = 1;
            //if it stararts with the *^un
            while (true)
            {
                TcpClient clientSocket = default(TcpClient);
                clientSocket = server.AcceptTcpClient();
                NetworkStream stream = clientSocket.GetStream();
                client = new Client(stream, clientSocket, userID, this);
                Console.Write("User " + userID + " Connected");
                userID++;
                //client.SetUserName();
                lock (clientListLock)
                {
                    //client.SetChatRoom();
                    clientList.Add(client);
                }
                MessageReceiver = new Thread(new ThreadStart(() => ReceiveAndRespond(client)));
                MessageReceiver.Start();
                Respond(client, client.userName + "has connected to the server");

            }
            //clientSocket.Close();
            //serverSocket.Stop();
            //Console.WriteLine("Exit");
            //Console.ReadLine();
        }
        //public void Receive()
        //{

        //}
        //private void UpdatChatRoom()
        //{
        //    if client.UserName
        //}
        private void Respond(Client client, string body)
        {
            UpdateChatList(client, body);
        }
        private void UpdateChatList(Client client, string body)
        {
            Message chatAddition = new Message(client, body);
            chatLog.Enqueue(chatAddition);
        }
        private void SendMessagesToClients(Message message)
        {
            foreach (Client client in clientList)
            {
                // check chatroom
                client.Send(message);
            }
        }

    }
}
