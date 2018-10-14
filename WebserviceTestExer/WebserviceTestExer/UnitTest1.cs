using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebserviceTestExer
{
    [TestClass]
    public class UnitTest1
    {
        JasonWebservice.MyWebServiceSoapClient client;
        [TestInitialize]
        public void Init()
        {
            Console.WriteLine("Webservice test start");
            this.client= new JasonWebservice.MyWebServiceSoapClient();
        }
        [TestMethod]
        public void TestMethod1()
        {
            
                var resultHelloWrld = this.client.HelloWorld();
                Assert.AreEqual(resultHelloWrld, "Hello World");

                var testPlus = this.client.Plus(1, 3);
                Assert.AreEqual(testPlus, 4);
            
        }

        [TestMethod]
        public void TestGetUsers()
        {
            var result = client.GetUsers(new JasonWebservice.CustomSoapHeaders() {
                UserName = "jason",
                PassWord = "yuan"
            });

            Assert.AreEqual(result.Length, 2);
        }
    }
}
