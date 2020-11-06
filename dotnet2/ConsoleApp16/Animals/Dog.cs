using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Animals
{
    public class Dog : Animal
    {
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

        int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                Console.WriteLine($"Возраст: {_age}");
            }
        }
      
        string _breed;
        public string Breed
        {
            get
            {
                return _breed;
            }
            set
            {
                Console.WriteLine($"Моя порода - {_breed}");
            }
        }

        public Dog(string name) : base(true)
        {
            _name = name;
        }
       
    }
}

