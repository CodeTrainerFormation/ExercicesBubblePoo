using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class IntExtension
    {
        public static int NextRand(this int seed, int maxValue)
        {
            Random randomNumberGenerator = new Random(seed);
            return randomNumberGenerator.Next(maxValue);
        }

        public static int NextRand(this int seed)
        {
            Random randomNumberGenerator = new Random(seed);
            return randomNumberGenerator.Next();
        }
    }
}
