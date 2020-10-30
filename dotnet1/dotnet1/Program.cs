using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько дней вы живете?");
            var days = Convert.ToInt32(Console.ReadLine());
            var years = days / 365;
            var ost = days % 365;
            var months = ost / 30;
            var day = days - years * 365 -months * 30;
            Console.WriteLine($"Привет, {years} лет, {months} месяц/ев, {day} дней"); //вывод
            if (years >= 18)
            {
                for (var i = 1; i <= 10; i++)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
                Console.WriteLine($"Поздравляю с совершеннолетием!!!");
            }
            else
            {
                Console.WriteLine($"Ты еще маленький");
            }

            Console.ReadKey();

        }
    }
}
