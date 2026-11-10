using Tyuiu.BochantsevAV.Sprint4.Task0.V15.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int[] nums = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            int expected = 138915;
            int actual = ds.GetMultOddArrEl(nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
