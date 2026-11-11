using Tyuiu.BochantsevAV.Sprint4.Task7.V12.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int result = ds.Calculate(3, 4, "658932125478");

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            int result = ds.Calculate(2, 3, "246824");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            int result = ds.Calculate(2, 3, "135791");

            Assert.AreEqual(26, result);
        }
    }
}
