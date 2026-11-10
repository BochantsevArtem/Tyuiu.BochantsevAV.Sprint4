using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BochantsevAV.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] array)
        {
            int result = 1;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    result *= number;
                }
            }

            return result;
        }
    }
}
