using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace GenNetProtocol
{
   public class BinarySerializeTool:ISerializeTool
    {
        public void Serialize<T>(Stream stream, T item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            stream.Seek(0, SeekOrigin.Begin);
            formatter.Serialize(stream, item);
        }

        public T Dserialize<T>(Stream stream, T item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            stream.Seek(0, SeekOrigin.Begin);
            return (T)formatter.Deserialize(stream);
        }
    }

   public class JsonSerializeTool : ISerializeTool
   {
       public void Serialize<T>(System.IO.Stream stream, T item)
       {
           DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(T));
           stream.Seek(0, SeekOrigin.Begin);
           formatter.WriteObject(stream, item);
       }

       public T Dserialize<T>(System.IO.Stream stream, T item)
       {
           DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(T));
           stream.Seek(0, SeekOrigin.Begin);
           return (T)formatter.ReadObject(stream);
       }
   }

}
