using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class LambdaExpression
    {
        static void main(string[] args)
        {
            GreetingsDelegate gd = (name) =>
            {
                return "Hello" + " " + name + " " + "a very good morning!";
            };
            string str = gd.Invoke("Onyil");
            Console.WriteLine(str);
        }
    }
}
