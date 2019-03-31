using InterfaceMediator;
using System;
using System.IO;

namespace JsonHandler
{
    public class JsonParser : IParserHandler
    {


        public bool CanParse(string filePath)
        {
                try
                {
                    new JsonParser().Parse(filePath);
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
            if (obj != null && format.Equals("JSON") || format.Equals(".JSON"))
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
