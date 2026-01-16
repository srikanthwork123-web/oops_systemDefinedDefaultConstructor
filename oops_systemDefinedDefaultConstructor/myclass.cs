using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_systemDefinedDefaultConstructor
{
    internal class myclass
    {
        int a;
        int b;
        //system defined default constructor compliler will assign some intial values to varaibles nased on datatype.
        //below is user defined default constructor created by programmer.here you can assign your customized values.
        public myclass()
        {
            Console.WriteLine("a value before assignment:" + a);
            Console.WriteLine("b value after assignment:" + b);
            a = 10;
            b = 20;
        }
        public void Display()
        {
        
            Console.WriteLine("a is:" + a);
            Console.WriteLine("b is:" + b);
        }
    }
}
