using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNetProtocol
{
    interface IEncryptionTool
    {
        byte[] Encrypt(byte[] _bytes);
        byte[] Dencrypt(byte[] _bytes);
    }
}
