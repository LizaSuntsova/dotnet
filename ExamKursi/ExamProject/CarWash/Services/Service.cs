using System;
using System.Collections.Generic;
using System.Text;

namespace ExamKursi.ExamProject.CarWash.Services
{
    class Service
    {
        public int Price;
        public DateTime Time;
        public Staff Staff;
        public Client Client;
        public string Name;

        public Service(string name, int price, Client client, Staff staff, DateTime time)
        {
            Name = name;
            Price = price;
            Time = time;
            Client = client;
            Staff = staff;
        }

        public void DoWork()
        {
            Staff.DoneWork++;
            Client.SpendMoney += Price;
            Client.BuyService++;
            Console.WriteLine("Для клиента " + Client.FullName + " выполнена услуга " + Name);
        }

    }
}
