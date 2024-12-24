using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class StatClass
    {
        public static void Test3(this Program p, int i)
        {
            Console.WriteLine("Method3: " + i);
        }
        public static long Factorial(this Int32 i)
        {
            if (i == 1)
            {
                return 1;
            }
            if (i == 2)
            {
                return 2;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }
        public static string ToProper(this String os)
        {
            if (os.Trim().Length > 0)
            {
                String ns = null;
                os = os.ToLower();
                string [] sarr  = os.Split(' ');
                foreach (var str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if(ns == null)
                        ns = new string(carr);
                    else
                        ns += " " + new string(carr);
                }
                return ns;
            }
            return os;
        }
    }
}
