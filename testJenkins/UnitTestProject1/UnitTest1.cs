using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testJenkins;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelloWorld()
        {
            try
            {
                var inputstr = "World";
                var exptectedstr = "Hello World";
                var teststr = bll.returnHello(inputstr);

                Assert.AreEqual(exptectedstr, teststr, false, "Failed to Match String");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}