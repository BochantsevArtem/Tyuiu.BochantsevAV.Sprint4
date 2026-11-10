using Tyuiu.BochantsevAV.Sprint4.Task1.V23.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива. С клавиатуры: 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, *");
            Console.WriteLine("* 5, 9, 9, 9                                                              *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[17];

            Console.WriteLine();
            Console.WriteLine("* ВВЕДИТЕ 17 ЧИСЕЛ ОТ 4 ДО 9:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("* Элемент [" + i + "] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                if (array[i] < 4 || array[i] > 9)
                {
                    Console.WriteLine("* Ошибка! Введите число от 4 до 9.");
                    i--;
                }
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:");

            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* Сумма четных элементов = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
