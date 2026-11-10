using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BochantsevAV.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int row = 2;
            int max = array[row, 0];

            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[row, i] > max)
                {
                    max = array[row, i];
                }
            }

            return max;
        }
    }
}
