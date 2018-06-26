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
            else
            {
                Assert.True(true);
            }
        }

        [Test]
        public void TestMethod2()
        {
            var inputstr = "World";
            var exptectedstr = "Hello World KaasKoek";
            var teststr = bll.returnHello(inputstr);

            if (exptectedstr != teststr)
            {
                Assert.True(true);
            }
            else
            {
                AssertionException ex = new AssertionException("String Matched");
                throw ex;
            }
        }
    }
}