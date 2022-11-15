using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal abstract class Person : IComparable<Person>
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

        //public int CompareTo(object? obj)
        //{
        //    if (!(obj is Person))
        //        throw new InvalidCastException("obj n'est pas une personne");

        //    Person person = (Person)obj;

        //    int value = this.Age - person.Age;

        //    if (value == 0)
        //        value = this.LastName.CompareTo(person.LastName);

        //    if (value == 0)
        //        value = this.FirstName.CompareTo(person.FirstName);

        //    return value;
        //}

        public int CompareTo(Person? person)
        {
            int value = this.Age - person.Age;

            if(value == 0)
                value = this.LastName.CompareTo(person.LastName);

            if(value == 0)
                value = this.FirstName.CompareTo(person.FirstName);

            return value;

            //if (this.Age > person.Age)
            //    return 1;
            //else if (this.Age < person.Age)
            //    return -1;
            //else
            //    return 0;
        }
    }
}
