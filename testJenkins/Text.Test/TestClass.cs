using NUnit.Framework;
using System;

using System;

using testJenkins;

namespace Text.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
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