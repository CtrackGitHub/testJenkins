using NUnit.Framework;

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

            if (exptectedstr == teststr)
            {
                Assert.True(true);
            }
            else
            {
                try
                {
                    Assert.Fail();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }
    }
}