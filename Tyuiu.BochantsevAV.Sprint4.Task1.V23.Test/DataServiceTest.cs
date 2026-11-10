using Tyuiu.BochantsevAV.Sprint4.Task1.V23.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };

            int expected = 36;
            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
