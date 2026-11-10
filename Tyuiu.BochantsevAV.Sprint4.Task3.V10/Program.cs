using Tyuiu.BochantsevAV.Sprint4.Task3.V10.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 8. Найдите максимальный     *");
            Console.WriteLine("* элемент в третьей строке массива.                                       *");
            Console.WriteLine("***************************************************************************");

            int[,] array =
            {
                { 5, 7, 6, 6, 5 },
                { 5, 5, 5, 4, 6 },
                { 8, 5, 7, 4, 7 },
                { 7, 6, 7, 4, 7 },
                { 5, 8, 7, 8, 8 }
            };

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
            Console.WriteLine("* Максимальный элемент третьей строки = " + result);

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
