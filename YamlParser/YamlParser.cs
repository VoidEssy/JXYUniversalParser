using FormatsEnums;
using InterfaceMediator;
using System;

namespace YamlHandler
{
    public class YamlParser : IParserHandler
    {
        public YamlParser()
        {
        }

        public bool CanParse(string filePath)
        {
                try
                {
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
        }

        public bool CanSerialize(object obj, Format format)
        {
            if (obj != null && format.Equals(Format.Yaml))
                return true;
            return false;
        }

        public object Parse(string filePath)
        {
            throw new NotImplementedException();
        }

        public object Serialize(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
