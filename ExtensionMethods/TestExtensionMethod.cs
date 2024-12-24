using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class TestExtensionMethod
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test3(2000);  p.Test2();   p.Test1();

            int x = 15;
            long result = x.Factorial();
            Console.WriteLine("Factorial of {0} is : {1}", x, result);

            string s = "hElLo hOw Are yoU";
            s = s.ToProper();
            Console.WriteLine(s);
        }
    }
}
