using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RpgEditor
{
    public static class XmlManager
    {
        //public static Type Type { get; private set; }
        public static T Load<T>(string filename)
        {
            T data;
            using (TextReader reader = new StreamReader(filename))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                data = (T)xml.Deserialize(reader);
            }
            return data;
        }
        public static void Save<T>(string filename, T data)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(writer, data);
            }
        }
    }
}
