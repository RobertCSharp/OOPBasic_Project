using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.AnimalsProject
{
    public class Bird : Animal
    {
        public Bird(string breed, string color) : base(breed, color)
        {
        }

        public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
