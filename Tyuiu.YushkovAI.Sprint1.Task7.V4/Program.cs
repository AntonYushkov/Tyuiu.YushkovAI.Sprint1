using Tyuiu.YushkovAI.Sprint1.Task7.V4.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task7.V4
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
            Console.WriteLine("* Задание #7                                                                                           *");
            Console.WriteLine("* Вариант #4                                                                                           *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Вычислить математическое выражение и вывести результат на экран.                                     *");
            Console.WriteLine("* z = ln(|(y - sqrt(|x|)) * (x - y / (x + x^2 / 4))|)                                                  *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                                                          *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double denominator = x + x * x / 4;
            double expression = (y - Math.Sqrt(Math.Abs(x))) *
                                (x - y / denominator);

            if (denominator == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: знаменатель не может быть равен нулю.");
                return;
            }

            if (expression == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: логарифм от нуля не определён.");
                return;
            }

            double result = ds.Calculate(x, y);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result:F3}                                                                                  *");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
