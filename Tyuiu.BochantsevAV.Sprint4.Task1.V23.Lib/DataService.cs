using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BochantsevAV.Sprint4.Task1.V23.Lib
{
    public class DataService : ISprint4Task1V23
    {
        public int Calculate(int[] array)
        {
            int result = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
            }

            return result;
        }
    }
}
