using FormatsEnums;
using InterfaceMediator;
using JsonHandler;
using System;
using System.IO;
using XMLHandler;
using YamlHandler;

namespace JXYPUniversalParser
{
    public class JXYController
    {
        private readonly IParserHandler[] handlers = new IParserHandler[] { new XmlParser(), new JsonParser(), new YamlParser() };

        public object ConvertToObject(string content)
        {
            foreach (var handler in handlers)
            {
                bool canParse = handler.CanParse(content);
                if (canParse)
                {
                    return handler.Parse(content);
                }
            }
            throw new Exception("Provided File doesn't fit any of the supported types please verify that you're supply the correct path to the file, supplied path:" + content);

        }

        public object ConvertToObjectFromFile(string path)
        {
            if (File.Exists(path))
            {
                ConvertToObject(File.ReadAllText(path));
            }
            throw new InvalidOperationException("File doesn't exist");
        }


        /// <summary>
        /// Converts file to one of the specified formats, with options to either just return the result of serialization as a string/obj or to write file to specified path and return the string.
        /// </summary>
        /// <param name="obj"> Object to be serialized</param>
        /// <param name="format"> Supply Format to convert to in an Enum</param>
        /// <param name="filePath"> Has to specify the format of the file in the filepath, ex MyPerson.Json || MyCar.XML etc.</param>
        /// <returns></returns>
        public string ConvertToFormat(object obj, Format format, string filePath = "")
        {
            foreach (var handler in handlers)
            {
                bool canParse = handler.CanSerialize(obj, format);
                if (canParse)
                {
                    var mediator = handler.Serialize(obj).ToString();
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        File.WriteAllText(filePath, mediator.ToString());
                    }
                    return mediator;

                }
            }
            throw new Exception("Provided object doesn't fit any of the supported types please verify that you're supplying the correct object");

        }
    }
}
