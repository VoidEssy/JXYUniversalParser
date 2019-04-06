using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace XMLHandler
{
    internal class Serializer
    {
        public T Deserialize<T>(string content) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StringReader str = new StringReader(content))
            {
                return (T)serializer.Deserialize(str);
            }
        }

        public object Serialize<T>(T Obj)
        {
            XmlSerializer serializer = new XmlSerializer(Obj.GetType());
            using (StringWriter sw = new StringWriter())
            {
                serializer.Serialize(sw, Obj);
                return sw.ToString();
            }
        }
    }
}
