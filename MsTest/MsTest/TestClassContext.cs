using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest
{
    [TestClass]
    public class TestClassContext
    {


        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }

            set { _testContext = value; }

        }


        [TestMethod]
        public void rj()
        {
            Console.WriteLine("This is Test Method one", TestContext.TestName);
        }



        [TestCleanup]
        public void rj2()
        {
            Console.WriteLine("This is After Test", TestContext.CurrentTestOutcome);
        }


    }
}
