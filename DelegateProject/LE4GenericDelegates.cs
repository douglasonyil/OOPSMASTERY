using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class LE4GenericDelegates
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> d1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double result = d1.Invoke(100, 34.5f, 100.00);
            Console.WriteLine(result);

            Action<int, float, double> d2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            d2.Invoke(100, 34.5f, 100.00);


            Predicate<string> d3 = (s) =>
            {
                if (s.Length > 5)
                {
                    return true;
                }
                return false;
            };
            bool status = d3.Invoke("Onyil to the world!");
            Console.WriteLine(status);
        }
    }
}
