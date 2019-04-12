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
            JXYController controller = new JXYController();
            Console.WriteLine(controller.ConvertToFormat(jsonObj, Format.Json));
            var result = controller.ConvertToObject(@"{""Network"": {""Host"": ""0.0.0.0"",""Port"": 23115},""Database"": {""Auth"": {""ConnectionString"": ""server = 127.0.0.1; port = 3306; user = nexusforever; password = nexusforever; database = nexus_forever_auth"",""Provider"": ""MySql""}}}");
            //Console.WriteLine(controller.ConvertToFormat(jsonObj, Format.Xml));
            //string content = @"<?xml version='1.0' encoding='utf-8'?><HealthCheckConfig version='1.6.307.0'><FileChecks><Check name='acconfig.csv' folder='shared'><Path>acconfig.csv</Path></Check></FileChecks></HealthCheckConfig>";
            //var result = controller.ConvertToObject(content);
            Console.ReadLine();
        }
    }
}
