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
    public class Server : ISpectated
    {
        public Client client;
        TcpListener server;
        HashSet<Client> clientList;
        public Queue<Message> chatLog;
        Object messageLock;
        Object clientListLock;
        Object setLock;
        Object removeLock;
        private Thread ClientAcceptor;
        private Thread MessageReceiver;
        private Thread MessageBroadcaster;
        public Server(string IP)
        {
            server = new TcpListener(IPAddress.Parse(IP), 9999);
            clientList = new HashSet<Client>();
            chatLog = new Queue<Message>();
            messageLock = new Object();
            clientListLock = new Object();
            setLock = new object();
            removeLock = new object();
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
                try
                {
                    Message message = client.Receive();
                    if (message.Body.StartsWith("*^LON"))
                    {

                        RemoveClient(message.sender);
                    }
                    else
                    {
                        chatLog.Enqueue(message);
                    }
                }
                catch
                {
                    Message logOffMessage = new Message(client, client.userName + " has logged off." + Environment.NewLine);
                    chatLog.Enqueue(logOffMessage);
                }
            }
        }
          public void RemoveClient(Client removedClient)
        {
            foreach (Client listedClient in clientList)
            {
                if (removedClient.userId == listedClient.userId)
                {
                    clientList.Remove(listedClient);
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
            while (true)
            {
                TcpClient clientSocket = default(TcpClient);
                clientSocket = server.AcceptTcpClient();
                NetworkStream stream = clientSocket.GetStream();
                client = new Client(stream, clientSocket, userID, this);
                Console.Write("User " + client.userId + " Connected");
                userID++;
                lock (clientListLock)
                {
                    clientList.Add(client);
                }
                MessageReceiver = new Thread(new ThreadStart(() => ReceiveAndRespond(client)));
                MessageReceiver.Start();
            }
        }
        private void SetChatRoom(string message)
        {
            client.chatRoom = message.Substring(4);
            Message joinMessage = new Message(client, "has joined.");
            SendMessagesToClients(joinMessage);
        }
        private void SendMessagesToClients(Message message)
        {
            foreach (Client client in clientList)
            {
                if (client.chatRoom == message.chatRoom)
                {
                    Console.WriteLine(client.userName + " is sending the message " + message.Body + " to the chat room " + client.chatRoom);
                    client.Send(message);
                }
            }
        }

    }
}
