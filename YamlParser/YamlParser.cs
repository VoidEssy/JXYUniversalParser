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

        public bool CanSerialize(object obj, string format)
        {
            format.ToUpper();
            if (obj != null && format.Equals("YAML") || format.Equals(".YAML"))
                return true;
            return false;
        }

        public object Parse(string filePath)
        {
            throw new NotImplementedException();
        }

        public string Serialize(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
