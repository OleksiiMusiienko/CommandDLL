using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessengerModel;
using System.Runtime.Serialization;

namespace CommandDLL
{
    [DataContract]
    public class ServerResponse
    {
        [DataMember]
        public List<User> list=new List<User>();
        [DataMember]
        public string command { get; set; }

        public ServerResponse() { }
        public ServerResponse(List<User> us, string com)
        {
            list = us;
            command = com;
        }
    }
}
