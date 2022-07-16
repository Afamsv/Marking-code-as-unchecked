using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marking_code_as_unchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 2147483647;
            int val2;

            unchecked
            {
                val2 = val1 + 1;
            }
            Console.WriteLine("Val1 is {0}", val1);
           Console.WriteLine("Val2 is {0}", val2);
        }
    }
}
