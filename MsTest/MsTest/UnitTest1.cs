using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest
{
    [TestClass]
    public class UnitTest1
    {



        public TestContext testcontext;

        public TestContext TestContext
        {
            get { return testcontext; }
            set { testcontext = value; }

        }


         //*******************************************************************************************//


        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Console.WriteLine("This is Before Assembly");
        }





        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("This is After Assembly");
        }




        [ClassInitialize]
        public static void BeforeClass(TestContext tc)
        {
            Console.WriteLine("This is Before Class");
        }






        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("This is After Class");
        }







        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This is After Test");
        }






        [TestMethod] // this is used to decl method as test method
        public void TestMethod1()
        {
            Console.WriteLine("This is Test Method one");
        }




        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This is Before Test");
        }




        [TestMethod, TestCategory("SmokeTest")] // this is used to decl method as test method
        public void TestMethod5()
        {
            Console.WriteLine("This is Test Method one");
        }



        [Ignore]
        [TestMethod, TestCategory("SmokeTest")]
        public void TestMethod2()
        {
            Console.WriteLine("This is Test Method two");
        }




        [TestMethod, ExpectedException(typeof(NullReferenceException))]
        public void TestMethod3()
        {
            Console.WriteLine("This is Test Method three");
            String b = null;
            Console.WriteLine(b.Length);
        }





        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(80, 23416728348467685)]
        [DataTestMethod]
        public void GivenDataFibonacciReturnsResultsOk(int number, int result)
        {
            //var fib = new Fib();
            //var actual = fib.Fibonacci(number);
            //Assert.AreEqual(result, actual);
        }




        // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\Users\RUSHIT  PATEL\source\repos\AutomationFrameWork1\AutomationFrameWork1\Data\CSVTEST.csv", "CSVTEST#csv", DataAccessMethod.Sequential)]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TestsData.csv", "TestsData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataDrivenTest()
        {
            int valueA = Convert.ToInt32(this.TestContext.DataRow["valueA"]);
            int valueB = Convert.ToInt32(this.TestContext.DataRow["valueB"]);
            int expected = Convert.ToInt32(this.TestContext.DataRow["expectedResult"]);
        }











    }
}
