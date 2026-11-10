using Tyuiu.BochantsevAV.Sprint4.Task2.V1.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };

            int expected = 384;
            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
