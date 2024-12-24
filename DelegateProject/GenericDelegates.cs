using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);
    internal class GenericDelegates
    {
        public static double AddNums1(int x,float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x,float y,double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool CheckLength(string s)
        {
            if(s.Length>5)
                return true;
            return false;
        }
        static void main(string[] args)
        {
            Func<int, float, double, double> d1 = AddNums1;
            double result = d1.Invoke(100, 34.5f, 100.00);
            Console.WriteLine(result);
            //Delegate1 d1 = AddNums1;
            //double result = d1.Invoke(100, 34.5f, 100.000);
            //Console.WriteLine(result);

            Action<int, float, double> d2 = AddNums2;
            d2.Invoke(100, 34.5f, 100.00);



            //Delegate2 d2 = AddNums2;
            //d2.Invoke(100, 34.5f, 100.000);

            Predicate<string> d3 = CheckLength;
            bool status = d3.Invoke("sex!");
            Console.WriteLine(status);

            //Delegate3 d3 = CheckLength;
            //bool status = d3.Invoke("Onyil Douglas");
            //Console.WriteLine(status);


        }
    }
}
