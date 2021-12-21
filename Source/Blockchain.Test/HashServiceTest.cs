using Blockchain.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blockchain.Test
{
    [TestClass]
    public class HashServiceTest
    {
        public HashServiceTest()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = HashService.Compute("Hello World");
        }
    }
}
