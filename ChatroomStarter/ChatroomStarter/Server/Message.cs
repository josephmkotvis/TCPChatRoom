using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Message
    {
        public Client sender;
        public string Body;
        public int UserId;
        public string chatRoom;
        //string chatRoom = general;
        public Message(Client Sender, string Body)
        {
            sender = Sender;
            this.Body = Body;
            this.UserId = Sender.UserId;
            this.chatRoom = sender.chatRoom;
            //chatRoom;C:\Users\josep\Documents\DevCodeCamp\WEEK8\TCPChatRoom\ChatroomStarter\ChatroomStarter\Server\Program.cs
            //maybe need a list of messages saved
        }
    }
}
