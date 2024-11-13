using Tyuiu.BlagihIA.Sprint4.Task2.V18.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Работа в С#                                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* заполненный случайными значениями  в диапазоне от 2 до 8 подсчитать     *");
            Console.WriteLine("* произведение четных элементов массива.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 }                   *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество символов массива");
            len = Convert.ToInt32(Console.ReadLine());


            int[] array = new int[len];

            Random rnd = new Random();

            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("Массив");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i] + "\t");
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
