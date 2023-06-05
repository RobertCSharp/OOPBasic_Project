using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs69OOP.PersonProject
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private Laptop laptop;
        Phone phone;

        public Person(string firstName, string lastName, int age, Laptop laptop, Phone phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.laptop = laptop;
            this.phone = phone;
        }

        public override string ToString()
        {
            return $"firstName: {firstName} lastName: {lastName} age: {age} laptop: {laptop} phone: {phone}";
        }
    }
}
