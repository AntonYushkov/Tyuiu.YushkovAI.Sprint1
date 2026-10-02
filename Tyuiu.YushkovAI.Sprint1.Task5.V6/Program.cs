using Tyuiu.YushkovAI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task5.V6
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
            Console.WriteLine("* Задание #5                                                                                           *");
            Console.WriteLine("* Вариант #6                                                                                           *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Пусть k — целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в зависимости от того, *");
            Console.WriteLine("* на какой день недели приходится k-й день невисокосного года, в котором 1 января — понедельник.     *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите номер дня года k (1-365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k < 1 || k > 365)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: значение k должно быть от 1 до 365.");
                return;
            }

            int result = ds.Calculate(k);

            string dayOfWeek = result switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => ""
            };

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result} ({dayOfWeek})                                                                      *");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
