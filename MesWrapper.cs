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
    public class MesWrapper
    {
        [DataMember]
        public int len { get; set; }
        public MesWrapper() { }
    }
}
