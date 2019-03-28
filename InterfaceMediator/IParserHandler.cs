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
        bool CanParse(string filePath);

        /// <summary>
        /// Generate an object from file at the filepath
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        object Parse(string filePath);
    }
}
