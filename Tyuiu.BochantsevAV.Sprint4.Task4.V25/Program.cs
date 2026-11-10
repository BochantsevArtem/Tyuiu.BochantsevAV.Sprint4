using Tyuiu.BochantsevAV.Sprint4.Task4.V25.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов.                    *");
            Console.WriteLine("* Найти сумму четных элементов массива.                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine();

            int[,] array = new int[5, 5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    while (true)
                    {
                        Console.Write("Введите элемент [" + i + "," + j + "] от 2 до 6: ");

                        if (int.TryParse(Console.ReadLine(), out int number)
                            && number >= 2 && number <= 6)
                        {
                            array[i, j] = number;
                            break;
                        }

                        Console.WriteLine("Ошибка! Введите целое число от 2 до 6.");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine();
            }

            DataService ds = new DataService();

            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* Сумма четных элементов массива = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
