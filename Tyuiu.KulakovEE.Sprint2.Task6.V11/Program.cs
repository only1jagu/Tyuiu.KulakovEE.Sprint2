using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KulakovEE.Sprint2.Task6.V11.Lib;

namespace Tyuiu.KulakovEE.Sprint2.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Кулаков Е.Е. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 2                                                                *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("*Выполнил: Кулаков Егор Евгеньевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет дата некоторого дня которая       *");
            Console.WriteLine("* характеризуется тремя натуральными числами: g (год), m                  *");
            Console.WriteLine("* (порядковый номер месяца) и n (число).                                  *");
            Console.WriteLine("*По заданным g, n и m определить дату следующего дня.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string res = Convert.ToString(ds.FindDateOfNextDay(g, m, n));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            if (m > 12)
            {
                Console.WriteLine("Такого месяца не существует");
            }
            else
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
