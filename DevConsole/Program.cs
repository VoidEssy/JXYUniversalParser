using FormatsEnums;
using JXYPUniversalParser;
using System;

namespace DevConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            object jsonObj = new object();
            jsonObj = new { Firstname = "Jimmy", Lastname = "Neutron" };
            Controller controller = new Controller();
            Console.WriteLine(controller.ConvertToFormat(jsonObj, Format.Json));
            Console.ReadLine();
        }
    }
}
