using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BochantsevAV.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] array)
        {
            int result = 1;

            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    result *= number;
                }
            }

            return result;
        }
    }
}
