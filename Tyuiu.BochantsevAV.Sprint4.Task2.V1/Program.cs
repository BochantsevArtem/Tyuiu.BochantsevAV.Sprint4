using Tyuiu.BochantsevAV.Sprint4.Task2.V1.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка одномерных массивов                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 9 подсчитать произведение четных         *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");

            Random random = new Random();
            int[] array = new int[10];

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write(array[i] + " ");
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* Произведение четных элементов = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
