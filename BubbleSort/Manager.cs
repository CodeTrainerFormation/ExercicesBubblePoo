using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Manager : Employee
    {
        public string Zone { get; set; }

        public Manager(string firstName = "Bebert", string lastName = "Simpson", int age = 30, int seniority = 0, string zone = "inconnue")
            : base(firstName, lastName, age, seniority)
        {
            //this.FirstName = firstName;
            //this.LastName = lastName;
            //this.Age = age;
            //this.Seniority = seniority;
            this.Zone = zone;
        }

        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("et je manage");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"zone : {this.Zone}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, zone : {this.Zone}";
        }

        public override void Eat()
        {
            Console.WriteLine("mange au restaurant");
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Manager))
                return false;

            Manager manager = (Manager) obj;

            if (manager.FirstName == this.FirstName
              && manager.LastName == this.LastName
              && manager.Age == this.Age
              && manager.Seniority == this.Seniority
              && manager.Zone == this.Zone)
                return true;
            else
                return false;
        }
    }
}
