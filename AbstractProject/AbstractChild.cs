using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class AbstractChild:AbstractParent
    {
        public override void Mult(int x, int y)
        {
            Console.WriteLine( x*y );
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine( x/y );
        }
        static void Main(string[] args)
        {
            AbstractChild aC = new AbstractChild();
            aC.Add(23, 234);
            aC.Mult(543, 10);
            aC.Sub(75, 5);
            aC.Div(100, 10);
        }
    }
}
