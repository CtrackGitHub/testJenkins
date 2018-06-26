using NUnit.Framework;
using System;
using testJenkins;

namespace NUnit.Tests1
{
    [TestFixture]
    //[ExpectedException(typeof(AssertionException))]
    public class TestClass
    {
        [TestCase]
        public void TestMethod()
        {
            var inputstr = "World";
            var exptectedstr = "Hello World";
            var teststr = bll.returnHello(inputstr);

            if (exptectedstr != teststr)
            {
                AssertionException ex = new AssertionException("Failed to Match string");
                throw ex;
            }
        }
    }
}