using Tyuiu.BochantsevAV.Sprint4.Task3.V10.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 5, 7, 6, 6, 5 },
                { 5, 5, 5, 4, 6 },
                { 8, 5, 7, 4, 7 },
                { 7, 6, 7, 4, 7 },
                { 5, 8, 7, 8, 8 }
            };

            int expected = 8;
            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
