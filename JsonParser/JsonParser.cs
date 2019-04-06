using FormatsEnums;
using InterfaceMediator;
using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonHandler
{
    public class JsonParser : IParserHandler
    {
        private JsonSerializer ser = new JsonSerializer();

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

        public bool CanSerialize(object obj, Format format)
        {
            if (obj != null && format.Equals(Format.Json))
                return true;
            return false;
        }

        public object Parse(string filePath)
        {
            JsonSerializer se = new JsonSerializer();
            using (JsonReader jr = new JsonTextReader(new StringReader(File.ReadAllText(filePath))))
                return se.Deserialize(jr);
        }

        public object Serialize(object obj)
        {
            using (TextWriter txt = new StringWriter())
            {
                ser.Serialize(txt, obj);
                return txt;
            }
        }
    }
}
