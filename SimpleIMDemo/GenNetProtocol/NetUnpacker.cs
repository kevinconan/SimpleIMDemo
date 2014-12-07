using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNetProtocol
{
    public class NetUnpacker
    {
        private byte[] bytes;
        public void NetUnpacker(byte[] _bytes)
        {
            this.bytes = _bytes;
        }
        public bool isFullPacket()
        {
            return this.bytes.Length == NetPacketHead.HEAD_SIZE + BitConverter.ToInt32(bytes, 12);
        }

        public NetPacket UnPacket()
        {
            #region 提取消息头
            NetPacketHead netPacketHead = ParsePacketHead();
            #endregion
            #region 提取消息体
             

            #endregion
        }

        private NetPacketHead ParsePacketHead()
        {
            NetPacketHead head = new NetPacketHead();
            head.Version = BitConverter.ToInt32(bytes, 0);
            head.PType = BitConverter.ToInt32(bytes, 4);
            head.EncryType = BitConverter.ToInt32(bytes, 8);
            head.dataLen = BitConverter.ToInt32(bytes, 12);
            return head;
        }

        private byte[] Dencrypt(byte[] data,EncryType type)
        {
            EncryptionToolCreator enCreator = new EncryptionToolCreator(type);
            return enCreator.CreateTool().Dencrypt(data);
        }

    }
}
