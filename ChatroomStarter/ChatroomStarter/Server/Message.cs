﻿using System;
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
        public Message(Client Sender, string Body)
        {
            sender = Sender;
            this.Body = Body;
            this.UserId = Sender.userId;
            this.chatRoom = sender.chatRoom;
        }
    }
}
