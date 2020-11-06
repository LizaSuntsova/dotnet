using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp16.Animals;


namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("test");
            dog.Name = "Pups";
            dog.IsLive=true;
            dog.Color = "серый";
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Color);
            dog.Live();
            Console.ReadKey();
        }
    }
}
