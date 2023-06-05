using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.AnimalsProject
{
    public class Mammal : Animal
    {
        public Mammal(string breed, string color) : base(breed, color)
        {
        }

        public virtual void Run()
        {
            Console.WriteLine("running");
        }
    }
}
