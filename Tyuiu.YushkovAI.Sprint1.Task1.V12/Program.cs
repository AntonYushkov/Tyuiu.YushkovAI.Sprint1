using Tyuiu.YushkovAI.Sprint1.Task1.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task1.V12
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
            Console.WriteLine("* Задание #1                                                                                           *");
            Console.WriteLine("* Вариант #12                                                                                          *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по       *");
            Console.WriteLine("* формуле (x+y)/6 и печатает его на экране.                                                            *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result}                                                                                  *");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
