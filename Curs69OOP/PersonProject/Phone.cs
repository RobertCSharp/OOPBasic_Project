using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.PersonProject
{
    public class Phone : Device
    {
        private string brand;
        private string color;
        private int price;

        public Phone(string brand, string color, int price) : base(brand, color, price)
        {
        }
    }
}
