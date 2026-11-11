using Tyuiu.BochantsevAV.Sprint4.Task7.V12.Lib;
namespace Tyuiu.BochantsevAV.Sprint4.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 658932125478.                         *");
            Console.WriteLine("* Преобразовать ее в матрицу 3 на 4 и подсчитать сумму нечетных чисел.    *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine();

            string value = "658932125478";

            Console.WriteLine("* Исходная строка: " + value);

            
            DataService ds = new DataService();

           
            int result = ds.Calculate(3, 4, value);

            
            Console.WriteLine();
            Console.WriteLine("* ПОЛУЧЕННАЯ МАТРИЦА:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int number = value[i * 4 + j] - '0';
                    Console.Write(number + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* Сумма нечетных чисел матрицы = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
