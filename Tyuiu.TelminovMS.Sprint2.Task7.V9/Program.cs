using Tyuiu.TelminovMS.Sprint2.Task7.V9.Lib;

namespace Tyuiu.TelminovMS.Sprint2.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные                 *");
            Console.WriteLine("* (вещественные значения) и вычисляет , находится ли точка с              *");
            Console.WriteLine("* координатами X,Y в заштрихованной области.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res) 
            {
                Console.WriteLine("Точка лежит в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не лежит в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
