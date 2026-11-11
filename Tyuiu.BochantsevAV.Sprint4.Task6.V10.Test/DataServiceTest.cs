using Tyuiu.BochantsevAV.Sprint4.Task6.V10.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string[] array =
            {
                "Театр",
                "Кино",
                "Музей",
                "Парк",
                "Зоопарк",
                "Концерт",
                "Выставка"
            };

            string[] expected =
            {
                "Театр",
                "Кино",
                "Музей",
                "Парк"
            };

            DataService ds = new DataService();

           
            string[] result = ds.Calculate(array);

           
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            
            string[] array =
            {
                "Программирование",
                "Информатика",
                "Математика"
            };

            string[] expected = { };

            DataService ds = new DataService();

            
            string[] result = ds.Calculate(array);

            
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            
            string[] array =
            {
                "Дом",
                "Кот",
                "Сад"
            };

            string[] expected =
            {
                "Дом",
                "Кот",
                "Сад"
            };

            DataService ds = new DataService();

           
            string[] result = ds.Calculate(array);

            
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
