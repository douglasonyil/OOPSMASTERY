using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public delegate string GreetingsDelegate(string name);
    internal class AnonymousMethods
    {
        //public static string Greetings(string name)
        
        static void main(string[] args)
        {
            GreetingsDelegate g = delegate (string name)
            {
                return "Hello" + " " + name + " " + "a very good morning";
            };
            string s = g.Invoke("Onyil");
            Console.WriteLine(s);
        }
    }
}
