using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.PersonProject
{
    public class Device
    {
        private string brand;
        private string color;
        private int price;

        public Device(string brand, string color, int price)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }

        public override string ToString()
        {
            return $"brand: {brand} color: {color} price: {price}";
        }
    }
}
