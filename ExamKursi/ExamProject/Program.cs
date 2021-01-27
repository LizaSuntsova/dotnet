using System;
using ExamKursi.ExamProject.CarWash;
using ExamKursi.ExamProject.CarWash.Services;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            static int NumberOfVisitirsPerPeriod(Client[] Name, DateTime Start, DateTime Finish)
            {
                var start = Start.ToBinary();
                var finish = Finish.ToBinary();
                int number = 0;
                for (int i = 0; i < Name.Length; i++)
                {
                    var time = Name[i].TimeVisit.ToBinary();
                    if (time >= start && time <= finish)
                    {
                        number++;
                    }
                }

                return number;
            }
            Client[] SessionLog = { new Client("Иванов Алексей Петрович", Sex.Male, 30, new DateTime(2020, 12, 28)),
            new Client("Семенов Тимур Андреевич", Sex.Male, 40, new DateTime(2020, 12, 25)),
            new Client("Петухова Анна Геннадьевна", Sex.Female, 20, new DateTime(2020, 12, 29)),
            new Client("Петров Егор Николаевич", Sex.Male, 35, new DateTime(2020, 12,30)),
            new Client("Сунцова Елизавета Александровна", Sex.Female, 18, new DateTime(2020, 12, 29)),
            };


            Staff[] staffs = {
            new Staff("Пушкин Олег Александрович"),
            new Staff("Пушкин Евгений Олегович"),
            new Staff("Сидоров Евгений Георгиевич"),
            new Staff("Алеексеев Антон Олегович"),
            };

            int k = SessionLog.Length;//Кол-во посетителей
            int n = 3; //Кол-во услуг
            var rnd = new Random();
            int c = rnd.Next(0, k); // берем рандомного человека
            var client = SessionLog[c];
            int s = rnd.Next(0, 3); // и рандомного сотрудника
            var staff = staffs[s];

            Service[] dos = {
                new Service("Стандартная мойка", 459,client, staff,client.TimeVisit),
                new Service("Экспресс-мойка", 500, client, staff, client.TimeVisit),
                new Service("Мойка-комфорт", 650, client, staff, client.TimeVisit),
                new Service("Престиж-мойка", 750, client, staff, client.TimeVisit)
            };

            Console.WriteLine("                  Оказанные услуги:                  ");

            for (int i = 0; i < n; i++)
            {

                int wash = rnd.Next(0, 4);
                var randserv = dos[wash];
                randserv.DoWork();
            }
            Console.WriteLine();

            Console.WriteLine("                  Сумма, которую потратил посетитель:                  ");
            Console.WriteLine();
            SessionLog[c].SpendKash();
            Console.WriteLine();

            Array.Sort(SessionLog);
            Console.WriteLine("                  Журнал посетителей автомойки:                  ");

            Console.WriteLine();

            for (int i = 0; i < SessionLog.Length; i++)
            {
                Console.WriteLine(SessionLog[i].Fio);
            }

            Console.WriteLine();
            Console.WriteLine("                  Количество работы, выполненой сотрудником автомойки:                  ");
            Console.WriteLine();
            staffs[s].DoWork();
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Посетителей в периоде: " + NumberOfVisitirsPerPeriod(SessionLog, new DateTime(2020, 12, 29), new DateTime(2020, 12, 31)));
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
