using Tyuiu.BlagihIA.Sprint4.Task3.V5.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Работа в С#                                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив 5 на 5 элементов заполненный        *");
            Console.WriteLine("* заполненный  значениями  в диапазоне от 2 до 9 подсчитать               *");
            Console.WriteLine("* сумму элементов в первом столбце массива.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* 3, 4, 8, 6, 3, 9, 9, 3, 6, 9,5, 6, 7, 2, 3,3, 6, 2, 3, 8,5, 7, 2, 6, 4  *");
            Console.WriteLine("***************************************************************************");




            int[,] array = new int[5, 5] { { 3, 4, 8, 6, 3 },
                                           { 9, 9, 3, 6, 9 },
                                           { 5, 6, 7, 2, 3 },
                                           { 3, 6, 2, 3, 8 },
                                           { 5, 7, 2, 6, 4 }
                                         };






            Console.WriteLine("Массив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
