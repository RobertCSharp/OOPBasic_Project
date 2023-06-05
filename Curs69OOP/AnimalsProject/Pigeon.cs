using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.AnimalsProject
{
    public class Pigeon : Bird
    {
        public Pigeon(string breed, string color) : base(breed, color)
        {
        }

        public override void Fly()
        {
            Console.WriteLine(GetType().Name + " is flying over houses");
        }
    }
}
