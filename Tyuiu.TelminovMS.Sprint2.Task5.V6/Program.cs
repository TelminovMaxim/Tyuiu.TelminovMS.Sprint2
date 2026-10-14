using Tyuiu.TelminovMS.Sprint2.Task5.V6.Lib;

namespace Tyuiu.TelminovMS.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастями игральных карт условно присвоены следующие порядковые номера:   *");
            Console.WriteLine("* масти ''пики'' - 1, масти ''трефы'' - 2, масти ''бубны'' - 3, масти е   *");
            Console.WriteLine("* ''червы'' - 4, а достоинству карт: ''валету'' - 11, ''даме'' - 12,      *");
            Console.WriteLine("* ''королю'' - 13, ''тузу'' - 14 (порядковые номера карт остальных        *");
            Console.WriteLine("* достоинств соответствуют их названиям). По заданному номеру масти       *");
            Console.WriteLine("* m (1<=m<=4) и номеру достоинства карты k (6<=k<=14) определить полное   *");
            Console.WriteLine("* название (масть и достоинство) соответствующей карты                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите m:");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите k:");
            int k = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindCardNameAndValue(m, k));


            Console.ReadKey();
        }
    }
}
