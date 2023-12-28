using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ServerResponse(List<User> us, Commands com)
        {
            list = us;
            command = com;
        }
    }
}
