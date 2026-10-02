using Tyuiu.YushkovAI.Sprint1.Task2.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task2.V12
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
            Console.WriteLine("* Задание #2                                                                                           *");
            Console.WriteLine("* Вариант #12                                                                                          *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Известны длины сторон параллелепипеда. Вычислить объем параллелепипеда.                              *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите длину параллелепипеда: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину параллелепипеда: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите высоту параллелепипеда: ");
            int height = Convert.ToInt32(Console.ReadLine());

            int result = ds.CalculateParallelepipedVolume(length, width, height);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result}                                                                                  *");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
