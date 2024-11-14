using Tyuiu.BlagihIA.Sprint4.Task5.V21.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Работа в С#                                                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив 5 на 5 элементов заполненный        *");
            Console.WriteLine("* случайными значениями  в диапазоне от -8 до 2 подсчитать                *");
            Console.WriteLine("* Заменить положительные элементы на 1.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int colomns = 5;

            int[,] mtrx = new int[rows,colomns];

            Random rnd = new Random();


            Console.WriteLine("***************************************************************************");

 

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < colomns; j++)
                {
                    mtrx[i, j] = rnd.Next(-8, 2);

                }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив");
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] res = ds.Calculate(mtrx);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
