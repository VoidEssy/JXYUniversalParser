using FormatsEnums;
using InterfaceMediator;
using System;
using System.Xml.Linq;

namespace XMLHandler
{
    public class XmlParser : IParserHandler
    {
        private static readonly Serializer ser = new Serializer();
        public XmlParser()
        {
        }
        public bool CanParse(string content)
        {
                XElement element;
                try
                {
                    element = XElement.Parse(content);
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
        }


        public bool CanSerialize(object obj, Format format)
        {
            if (obj != null && format.Equals(Format.Xml))
                return true;
            return false;
        }

        public object Parse(string filePath)
        {
            return ser.Deserialize<object>(filePath);
        }

        public object Serialize(object obj)
        {
            return ser.Serialize(obj);
        }
    }
}
