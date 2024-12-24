using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProjects
{
    internal class Generics
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }
        static void main(string[] args)
        {
            Generics obj = new Generics();
            bool result = obj.Compare<bool>(true, true);
            Console.WriteLine(result);
            bool result1 = obj.Compare<int>(20, 30);
            Console.WriteLine(result1);
        }
    }
}
