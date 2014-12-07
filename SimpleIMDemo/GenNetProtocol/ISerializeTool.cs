using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNetProtocol
{
    interface ISerializeTool
    {
        void Serialize<T>(System.IO.Stream stream, T item);
        T Dserialize<T>(System.IO.Stream stream, T item);
    }
}
