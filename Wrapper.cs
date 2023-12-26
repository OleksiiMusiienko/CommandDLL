using MessengerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommandDLL
{
    [DataContract]
    public class Wrapper
    {
        public enum Commands {Registratioin, Authorization, Redact}
        [DataMember]
        public User user { get; set; }
        [DataMember]
        public Commands commands { get; set; }
        
        public Wrapper() { }
        public Wrapper(User user, Commands commands)
        {
            this.user = user;
            this.commands = commands;
        }
    }
}
