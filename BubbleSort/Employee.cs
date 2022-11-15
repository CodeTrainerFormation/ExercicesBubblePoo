using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Employee : Person
    {
        #region Fields
        private static int counter = 0;
        private readonly int employeeId;
        private int seniority;
        #endregion

        #region Constructors
        public Employee()
            : this("Ted", "Mosby", 30, 3)
        {
        }

        public Employee(string firstName, string lastName, int age, int seniority)
            : base(firstName, lastName, age)
        {
            //base.FirstName = firstName;
            //base.LastName = lastName;
            //base.Age = age;
            this.seniority = seniority;
            this.employeeId = ++Employee.counter;

            //int a = 0;   // a vaut 0
            //a = a + 1;   // a vaut 1
            //a += 1;      // a vaut 2
            //int b = a++; // a vaut 3, b vaut 2
            //int c = ++a; // a vaut 4, c vaut 4
        }
        #endregion

        #region Methods
        public virtual void DoWork()
        {
            Console.WriteLine("Je travaille");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, empId: {this.employeeId}, employé depuis {this.seniority} an(s)";
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"{base.ToString()}, empId: {this.employeeId}, employé depuis {this.seniority} an(s)");
        }

        public override void Eat()
        {
            Console.WriteLine("mange un sandwich");
        }
        #endregion
    }
}
