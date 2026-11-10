using Tyuiu.BochantsevAV.Sprint4.Task0.V15.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.  {9, 8, 7, 6, 5, 7, 3, 2, 7, 3}             *");
            Console.WriteLine("***************************************************************************");

            int[] nums = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            DataService ds = new DataService();
            int result = ds.GetMultOddArrEl(nums);

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:");
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", nums));

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine();

            Console.WriteLine("* Произведение нечетных элементов = " + result);

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
