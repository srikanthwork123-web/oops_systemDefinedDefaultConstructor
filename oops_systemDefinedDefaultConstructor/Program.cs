using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_systemDefinedDefaultConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass mc = new myclass();
            mc.Display();
            Console.ReadLine();
        }
    }
}
/*
 *output:
a value before assignment:0
b value after assignment:0
a is:10
b is:20
*/