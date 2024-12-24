using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal interface ITestInterface1
    {
        void Add(int a, int b);
    }
    interface ITestInterface2:ITestInterface1 
    {
        void Sub(int a, int b);
    }
    class ImplementationClass : ITestInterface2
    {
        //void ITestInterface1.Add(int a, int b)
        //{
        //    Console.WriteLine(a+b);
        //}
        //void ITestInterface2.Sub(int a, int b)
        //{
        //    Console.WriteLine(a-b);
        //}

        public void Add(int a, int b) { Console.WriteLine(a+b); }
        public void Sub(int a, int b) { Console.WriteLine(a-b); }
        static void Main(string[] args)
        {
            ImplementationClass im = new ImplementationClass();
            ITestInterface2 i = im;
            i.Add(1, 2);
            i.Sub(1, 2);
            //im.Add(1, 2);
            //im.Sub(1, 2);
            //Console.WriteLine(im.Add());
        }
    }
    
}
