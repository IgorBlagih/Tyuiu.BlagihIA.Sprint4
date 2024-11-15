using Tyuiu.BlagihIA.Sprint4.Task6.V30.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Работа в С#                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Береза, Дуб, Клён, Сосна,Пихта,Осина]      *");
            Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых больше  *");
            Console.WriteLine("* 5 символов.                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");



            string[] array = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            string[] res= ds.Calculate(array);



            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i]);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < res.GetLength(0); i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
    }

