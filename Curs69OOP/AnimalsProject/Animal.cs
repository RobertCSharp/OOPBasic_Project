using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.AnimalsProject
{
    public class Animal
    {
        private string breed;
        private string color;

        public Animal(string breed, string color)
        {
            this.breed = breed;
            this.color = color;
        }

        public override string ToString()
        {
            return $"{GetType().Name} breed: {breed} color: {color}";

        }
    }
}
