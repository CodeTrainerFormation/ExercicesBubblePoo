using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class IntegerValueException : ArgumentException
    {
        public IntegerValueException()
            : base("La valeur n'est pas un entier !")
        {
        }
    }
}
