using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class MyExtensions
    {
        public static string ReplaceDashes(this string message)
        {
            return message.Replace("-", "*");
        }

        public static void DisplayPerson(this Person person)
        {
            Console.WriteLine(person);
        }

        public static void DisplayPeople(this Person[] people)
        {
            foreach (Person person in people)
            {
                person.DisplayPerson();
            }
        }
    }
}
