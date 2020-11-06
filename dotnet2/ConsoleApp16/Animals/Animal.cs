using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Animals
{
    public abstract class Animal : IMove
    {
        public bool IsLive;
        public Animal(bool isLive)
        {
            IsLive = isLive;
        }

        public int Live()
        {
            Console.WriteLine("I live:)");
            return 1;
        }

        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = $"{value}";
            }
        }

        string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                Console.WriteLine($"Мой цвет - {value}");
            }
        }

    }
}
