﻿using MessengerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommandDLL
{
    [DataContract]
    public class ListMessage : MesWrapper
    {
        [DataMember]
        public List<Message> listMessages;
        public ListMessage(): base() { }
    }
}
