using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNetProtocol
{
    public enum PacketType
    {
        STRING = 0,
        BINARY = 1,
        COMPLEX = 2
    }
    public enum EncryType
    {
        NONE = 0,
        RSA = 1
    }
    public class NetPacketHead
    {
        public const Int32 HEAD_SIZE = 16;
        public Int32 Version { get; set; }
        public Int32 PType { get; set; }
        public Int32 EncryType { get; set; }
        public Int32 dataLen { get; set; }

    }
}
