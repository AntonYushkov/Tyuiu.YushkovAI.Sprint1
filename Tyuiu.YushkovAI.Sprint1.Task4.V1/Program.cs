using Tyuiu.YushkovAI.Sprint1.Task4.V1.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
            Console.WriteLine("* Задание #4                                                                                           *");
            Console.WriteLine("* Вариант #1                                                                                           *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по       *");
            Console.WriteLine("* формуле 1/(x+2)^2 и печатает его на экране. Ответ округлить до 3 знаков после запятой.               *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x == -2)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: при x = -2 выражение не определено.");
                return;
            }

            double result = ds.Calculate(x);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result:F3}                                                                                  *");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
