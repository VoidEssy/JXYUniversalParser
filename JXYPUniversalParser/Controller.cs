using InterfaceMediator;
using JsonHandler;
using System;
using System.IO;
using XMLHandler;
using YamlHandler;

namespace JXYPUniversalParser
{
    public class Controller
    {
        private readonly IParserHandler[] handlers = new IParserHandler[] { new XmlParser(), new JsonParser(), new YamlParser() };

        public object ConvertToObject(string path)
        {
            if (File.Exists(path))
            {
                foreach (var handler in handlers)
                {
                    bool canParse = handler.CanParse(path);
                    if (canParse)
                    {
                        return handler.Parse(path);
                    }
                }
                throw new Exception("Provided File doesn't fit any of the supported types please verify that you're supply the correct path to the file, supplied path:" + path);
            }
            throw new InvalidOperationException("File doesn't exist");

        }
    }
}
