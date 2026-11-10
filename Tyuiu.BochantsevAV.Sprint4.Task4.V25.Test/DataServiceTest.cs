using Tyuiu.BochantsevAV.Sprint4.Task4.V25.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task4.V25.Test
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
                { 3, 2, 4, 4, 4 },
                { 2, 6, 6, 3, 2 },
                { 4, 2, 5, 5, 3 },
                { 5, 5, 6, 4, 3 },
                { 2, 6, 5, 6, 2 }
            };

            int expected = 62;

            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSumEven_AllOdd_ReturnsZero()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 3, 3, 3, 3, 3 },
                { 5, 5, 5, 5, 5 },
                { 3, 3, 3, 3, 3 },
                { 5, 5, 5, 5, 5 },
                { 3, 3, 3, 3, 3 }
            };

            int expected = 0;

            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
