using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.AnimalsProject
{
    public class Dog : Mammal
    {
        public Dog(string breed, string color) : base(breed, color)
        {
        }

        public override void Run()
        {
            Console.WriteLine(GetType().Name + " is running very fast");
        }
    }
}
