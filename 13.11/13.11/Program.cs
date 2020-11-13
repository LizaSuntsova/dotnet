using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{

    class Program
    {
        static public (int, bool) Prov (string a, string b)
        {
            try
            {
                int c = Convert.ToInt32(a);
                int d = Convert.ToInt32(b);
            }
            catch
            {
                throw new MyException();
            }
            return(1, true)
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введеите 2 целых числа:");

            try
            {
                var t = Prov("", "");
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            //string c = Console.ReadLine();
            int  a = Convert.ToInt32(Console.ReadLine());

            //string d = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            Console.WriteLine("Выберите:");
            Console.WriteLine("1: Сложение");
            Console.WriteLine("2: Вычитание");
            Console.WriteLine("3: Умножение");
            Console.WriteLine("4: Деление");

            Console.WriteLine();
            int result = -1;

            var typeOperation = (Podchet)Convert.ToInt32(Console.ReadLine());

            if (!Enum.IsDefined(typeof(Podchet), typeOperation))
            {
                Console.WriteLine("Sad");
            }

                switch (typeOperation)
                {
                case Podchet.Add:
                    result = a + b;
                        break;
                    case Podchet.Sub:
                    result = a - b;
                    break;
                    case Podchet.Mul:
                    result = a * b;
                    break;
                    case Podchet.Div:
                    try
                    {
                        result = a / b;
                    }
                    catch
                    {
                        Console.WriteLine("Нельзя деление на 0!!!");
                        break;
                    }
                    result = a / b;
                    break;
                }


            Console.WriteLine($"Полученный результат: {result}");
            Console.ReadKey();
        }
    }
}
