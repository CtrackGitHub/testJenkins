using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Test.ServiceReference1;

namespace WCF.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void ServiceRefence()
        {
            Service1Client client = new Service1Client();
            var input = 10;
            var exptectedstr = string.Format("You entered: {0}", input);
            var teststr = client.GetData(10);
            if (exptectedstr == teststr)
            {
                Assert.True(true, $"Success: {exptectedstr}");
            }
            else
            {
                AssertionException ex = new AssertionException("Failed");
                throw ex;
            }
        }
    }
}