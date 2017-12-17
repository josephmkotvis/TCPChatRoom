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
        public Message Receive()
        { 
            //
            //recieves string and calls function to generate message object and check for sentinals
            //
            byte[] receivedMessage = new byte[256];
            stream.Read(receivedMessage, 0, receivedMessage.Length);
            string receivedMessageString = Encoding.ASCII.GetString(RemoveZerozInMessage(receivedMessage));
            Message checkedMessage = CheckMessage(receivedMessageString);
            return checkedMessage;

        }

        private Message CheckMessage(string message)
        {
            //
            // this function now checks for sentinals (the signifiers) and creates a message accordingly and changes what needs to be changed.
            // the message is then sent to the server for boadcast
            //

            if (message.StartsWith("*^CR"))
            {
                //
                // calls SetChatRoom to change chatromm and then creates the joined message to broadcast
                //

                SetChatRoom(message);
                Message joinMessage = new Message(this, "has joined.");
                return joinMessage;
            }
            else if (message.StartsWith("*^UN"))
            {
                //saves old username, changes username, then creates a message to show what the name was changed from 
                //
                //
                string oldName = userName;
                userName = message.Substring(4);
                Message namechangedMessage = new Message(this, "has changed name from " + oldName + " to " + userName + ".");
                return namechangedMessage;
            }
            else
            {
                //
                //creates a regular message if no setinal encountered.
                //
                Message sentMessage = new Message(this, message);
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
