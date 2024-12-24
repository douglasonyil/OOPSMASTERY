using System;
using System.Collections;
namespace CollectionProjects
{
    internal class Program
    {
        static void main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(220);
            al.Add(240);
            Console.WriteLine(al.Capacity);
            al.Add(260);
            al.Add(280);
            al.Add(300);
            al.Add(320);
            Console.WriteLine(al.Capacity);
            al.Add(340);
            al.Add(360);
            Console.WriteLine(al.Capacity);
            al.Add(380);
            al.Add(640);
            Console.WriteLine(al.Capacity);
            al.Add(660);
            al.Add(680);
            Console.WriteLine(al.Capacity);

            foreach (var obj in al )
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            al.Insert(3, 1000);
            foreach (var obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            al.RemoveAt(0);
            foreach (var obj in al)
            {
                Console.Write(obj + " ");
            }
        }
    }
}
