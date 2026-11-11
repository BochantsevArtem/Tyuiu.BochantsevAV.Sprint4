using Tyuiu.BochantsevAV.Sprint4.Task5.V2.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array =
           {
                { -1,  2, -3,  4,  5 },
                {  1, -2,  3, -4,  5 },
                { -1, -2, -3, -4, -5 },
                {  1,  2,  3,  4,  5 },
                { -1,  2,  3,  4,  5 }
            };

            DataService ds = new DataService();

            int result = ds.Calculate(array);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Calculate_NoNegativeElements_ReturnsZero()
        {
            int[,] array = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = 3;
                }
            }

            DataService ds = new DataService();

            int result = ds.Calculate(array);

            Assert.AreEqual(0, result);
        }
    }
}
