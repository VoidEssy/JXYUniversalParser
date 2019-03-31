using InterfaceMediator;
using System;
using System.IO;

namespace JsonHandler
{
    public class JsonParser : IParserHandler
    {


        public bool CanParse(string filePath)
        {
            if (File.Exists(filePath))
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
            else
            {
                throw new InvalidOperationException("File doesn't exist");
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
