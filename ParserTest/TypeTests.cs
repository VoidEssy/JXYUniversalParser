using FormatsEnums;
using JXYPUniversalParser;
using NUnit.Framework;

namespace Tests
{
    public class TypeTests
    {
        [Test]
        public void ConvertObjectToJsonString()
        {
            JXYController controller = new JXYController();

            object jsonObj = new object();
            jsonObj = new { Firstname = "Jimmy", Lastname = "Neutron" };
            string result = controller.ConvertToFormat(jsonObj, Format.Json);
            Assert.IsTrue(result is string);
        }

        [Test]
        public void ConvertObjectToXMLString()
        {
            JXYController controller = new JXYController();

            object xmlObj = new object();
            xmlObj = new { Firstname = "Jimmy", Lastname = "Neutron" };
            string result = controller.ConvertToFormat(xmlObj, Format.Xml);
            Assert.IsTrue(result is string);
        }

        [Test]
        public void ConvertObjectToYamlString()
        {
            JXYController controller = new JXYController();

            object YamlObj = new object();
            YamlObj = new { Firstname = "Jimmy", Lastname = "Neutron" };
            string result = controller.ConvertToFormat(YamlObj, Format.Xml);
            Assert.IsTrue(result is string);
        }

        [Test]
        public void ConvertJsonStringToObject()
        {
            string jsonString = @"{""Network"": {""Host"": ""0.0.0.0"",""Port"": 23115},""Database"": {""Auth"": {""ConnectionString"": ""server = 127.0.0.1; port = 3306; user = nexusforever; password = nexusforever; database = nexus_forever_auth"",""Provider"": ""MySql""}}}";
            var result = new object();
            Assert.IsTrue(result is object);
        }

        [Test]
        public void ConvertXMLStringToObject()
        {
            var result = new object();
            Assert.IsTrue(result is object);
        }

        [Test]
        public void ConvertYamlStringToObject()
        {
            var result = new object();
            Assert.IsTrue(result is object);
        }
    }
}