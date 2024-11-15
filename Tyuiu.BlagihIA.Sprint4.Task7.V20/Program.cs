using Tyuiu.BlagihIA.Sprint4.Task7.V20.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task7.V20
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

            string str = "357951248632587";

            int[,] mtrx = new int[5, 3];

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mtrx[i, j] = int.Parse(str[i * 3 + j].ToString());
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(5, 3, str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        }
    }

