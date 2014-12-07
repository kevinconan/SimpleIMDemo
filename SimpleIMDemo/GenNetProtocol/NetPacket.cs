using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNetProtocol
{
   public class NetPacket
    {
        public NetPacketHead PacketHead { get; set; }
        public object Data { get; set; }
        public Int32 CRC { get; set; }
    }
}
