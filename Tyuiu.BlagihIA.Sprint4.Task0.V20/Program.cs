using Tyuiu.BlagihIA.Sprint4.Task0.V20.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки  работы в С#                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант 20                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* заполненный  значениями  в диапазоне от 0 до 9 подсчитать               *");
            Console.WriteLine("* произведение четных элементов массива.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* {4 ,8 ,7 ,6 ,5 ,8 ,2 ,4 ,3 ,2}                                          *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 }; 

            double res = ds.GetMultEvenArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
        }
    }
}
