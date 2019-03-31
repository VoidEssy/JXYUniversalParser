using InterfaceMediator;
using System;
using System.IO;
using System.Xml.Linq;

namespace XMLHandler
{
    public class XmlParser : IParserHandler
    {
        private static readonly Serializer ser = new Serializer();
        public XmlParser()
        {
        }
        public bool CanParse(string filePath)
        {
            if (File.Exists(filePath))
            {
                XElement element;
                try
                {
                    element = XElement.Load(filePath);
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }else
            {
                throw new InvalidOperationException("File doesn't exist");
            }
        }


        public bool CanSerialize(object obj, string format)
        {
            format.ToUpper();
            if (obj != null && format.Equals("XML") || format.Equals(".XML"))
                return true;
            return false;
        }

        public object Parse(string filePath)
        {
            Path.GetFullPath(filePath);
            return ser.Deserialize<object>(filePath);
        }

        public string Serialize(object obj)
        {
            return ser.Serialize(obj);
        }
    }
}
