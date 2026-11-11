using Tyuiu.BochantsevAV.Sprint4.Task6.V10.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных:                                            *");
            Console.WriteLine("* Театр, Кино, Музей, Парк, Зоопарк, Концерт, Выставка.                   *");
            Console.WriteLine("* Используя класс Array, вывести элементы массива,                        *");
            Console.WriteLine("* длина которых меньше 7 символов.                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine();

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

            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:");

            foreach (string item in array)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            DataService ds = new DataService();

            string[] result = ds.Calculate(array);

            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* Элементы, длина которых меньше 7 символов:");

            foreach (string item in result)
            {
                Console.WriteLine("* " + item);
            }

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
