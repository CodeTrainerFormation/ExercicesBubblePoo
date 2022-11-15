using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class PersonComparer : IComparer, IComparer<Person>
    {
        private bool isAscendant = true;

        public PersonComparer()
        {
        }

        public PersonComparer(bool isAscendant)
        {
            this.isAscendant = isAscendant;
        }

        public int Compare(Person? p1, Person? p2)
        {
            int value = p1.Age - p2.Age;

            if (value == 0)
                value = p1.LastName.CompareTo(p2.LastName);

            if (value == 0)
                value = p1.FirstName.CompareTo(p2.FirstName);


            if (this.isAscendant)
                return value;
            else
                return -value;
        }

        public int Compare(object? obj1, object? obj2)
        {
            if (!(obj1 is Person && obj2 is Person))
                throw new InvalidCastException("obj n'est pas une personne");

            Person p1 = (Person) obj1;
            Person p2 = (Person) obj2;

            int value = p1.Age - p2.Age;

            if (value == 0)
                value = p1.LastName.CompareTo(p2.LastName);

            if (value == 0)
                value = p1.FirstName.CompareTo(p2.FirstName);

            if (this.isAscendant)
                return value;
            else
                return -value;
        }
    }
}
