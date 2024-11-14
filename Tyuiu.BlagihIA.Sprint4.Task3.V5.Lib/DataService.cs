using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BlagihIA.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            


            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
               for (int j = 0; j < 1; j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }
    }
}
