using FormatsEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceMediator
{
    public interface IParserHandler
    {
        /// <summary>
        /// Verify that the file at the end of the path can be parsed
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        bool CanParse(string content);

        /// <summary>
        /// Check if the object can be serialized into output data
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        bool CanSerialize(object obj, Format format);

        /// <summary>
        /// Generate an object from file at the filepath
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        object Parse(string content);

        /// <summary>
        /// Serialize Obj to output format
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        object Serialize(object obj);
    }
}
