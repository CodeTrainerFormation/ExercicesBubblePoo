using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName)
            : this(firstName, lastName, 30)
        {
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public abstract void Eat();

        public virtual void Display()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName}, {this.Age} yo");
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, {this.Age} yo";
        }
    }
}
