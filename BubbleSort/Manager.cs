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

        //public Manager()
        //    : base()
        //{
        //}
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
    }
}
