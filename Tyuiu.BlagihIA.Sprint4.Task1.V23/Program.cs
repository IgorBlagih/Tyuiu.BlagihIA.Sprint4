using Tyuiu.BlagihIA.Sprint4.Task1.V23.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Работа в С#                                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов заполненный         *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 4 до 9 подсчитать    *");
            Console.WriteLine("* сумму четных элементов массива.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 }                   *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество символов массива");
            len = Convert.ToInt32(Console.ReadLine());


            int[] array = new int[len];

            for (int i = 0; i < len  ; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Массив");
            for (int i = 0; i < len ; i++)
            {
                Console.WriteLine(array[i] + "\t" );
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
