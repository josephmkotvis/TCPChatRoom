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
        Object setLock;
        private Thread ClientAcceptor;
        private Thread MessageReceiver;
        private Thread MessageBroadcaster;
        List<Thread> Recievers;
        //List<Queue<String[Message]
        // list of ques
        public Server(string IP)
        {
            server = new TcpListener(IPAddress.Parse(IP), 9999);
            clientList = new HashSet<Client>();
            chatLog = new Queue<Message>();
            messageLock = new Object();
            Recievers = new List<Thread>();
            clientListLock = new Object();
            setLock = new object();
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
                    //
                    // changed client.receive to return a message object instead of string then just enqueue it bypassing respond and update chat log
                    //
                   
                    Message message = client.Receive();
                    chatLog.Enqueue(message);

                    //
                    //commented out this portion because moved the checks to the server client. (did not move ID one because already commented out
                    //

                    //if (message.StartsWith("*^ID"))
                    //{
                    //    currentID = Convert.ToInt32(message);
                    //}
                    //if (message.StartsWith("*^CR"))
                    //{
                    //    SetChatRoom(message);
                    //}
                    //else if (message.StartsWith("*^UN"))
                    //{
                    //    client.userName = message.Substring(4);
                    //    Console.WriteLine("User " + client.userId + " has set their user name to " + client.userName);
                    //}
                    //else
                    //{
                    //    Console.WriteLine(message);
                    //    Respond(client, message);
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    //
                    //here is where you would notify if someone left the client.... not just chatroom
                    //
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
                Recievers.Add(MessageReceiver);

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
        private void SetChatRoom(string message)
        {
            client.chatRoom = message.Substring(4);
            Message joinMessage = new Message(client, "has joined.");
            SendMessagesToClients(joinMessage);

        }
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
                if (client.chatRoom == message.chatRoom)
                {
                    Console.WriteLine(client.userName + " is sending the message " + message.Body + " to the chat room " + client.chatRoom);
                    client.Send(message);
                }
                // check chatroom
            }
        }

    }
}
