using Tyuiu.YushkovAI.Sprint1.Task6.V7.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task6.V7
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
            Console.WriteLine("* Задание #6                                                                                           *");
            Console.WriteLine("* Вариант #7                                                                                           *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Пользователь вводит текст. Напечатать все слова, удалив из них последнюю букву.                     *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите текст: ");
            string value = Console.ReadLine() ?? "";

            string result = ds.DeleteLastLetter(value);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result}                                                                                  *");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
