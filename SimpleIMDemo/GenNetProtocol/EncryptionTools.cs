using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNetProtocol
{
    public class EncryptionToolCreator
    {
        private EncryType type;
        public EncryptionToolCreator(EncryType _type)
        {
            this.type = _type;
        }
        public IEncryptionTool CreateTool() 
        {
            switch (type)
            { 
                case EncryType.RSA:
                    return new RSAEncryptionTool();
                default :
                    return new NoneEncryptionTool();
            }
        }
    }

    public class NoneEncryptionTool : IEncryptionTool
    {
        public byte[] Encrypt(byte[] _bytes)
        {
            return _bytes;
        }

        public byte[] Dencrypt(byte[] _bytes)
        {
            return _bytes;
        }
    }

    public class RSAEncryptionTool : IEncryptionTool
    {
        public byte[] Encrypt(byte[] _bytes)
        {
            throw new NotImplementedException();
        }

        public byte[] Dencrypt(byte[] _bytes)
        {
            throw new NotImplementedException();
        }
    }


}
