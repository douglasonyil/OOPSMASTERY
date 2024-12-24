using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method1");
        }
        public void Test2()
        {
            Console.WriteLine("Method2");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1();  p.Test2(); 
        }
    }
}
