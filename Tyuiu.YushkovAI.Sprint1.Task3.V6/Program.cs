using Tyuiu.YushkovAI.Sprint1.Task3.V6.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task3.V6
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
            Console.WriteLine("* Задание #3                                                                                           *");
            Console.WriteLine("* Вариант #6                                                                                           *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу (туда и обратно).              *");
            Console.WriteLine("* Исходные данные: расстояние до дачи, расход бензина и цена одного литра бензина.                     *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                                                          *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите расстояние до дачи (км): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите расход бензина (л на 100 км): ");
            double gasFlow = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите цену одного литра бензина (руб.): ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());

            double result = ds.TravelCost(distance, gasFlow, gasPrice);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result:F3} руб.                                                                          *");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
