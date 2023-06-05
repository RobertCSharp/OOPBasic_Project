using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.AnimalsProject
{
    public class Eagle : Bird
    {
        public Eagle(string breed, string color) : base(breed, color)
        {
        }

        public override void Fly()
        {
            Console.WriteLine(GetType().Name + " is flying at speed of 200 km/h");
        }
    }
}
