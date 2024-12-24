using System;
using System.Collections;
namespace CollectionProjects
{
    public class HashTable
    {
        static void main()
        {
            Hashtable ht = new Hashtable();

            ht.Add("Eid", 2000);
            ht.Add("Ename", "Douglas Onyil");
            ht.Add("Job", "Software Developer");
            ht.Add("Salary", 1000000);
            ht.Add("Phone Number", 0703666909);
            ht.Add("Email", "douglasonyil91@gmail.com");
            ht.Add("DepName", "Developer");
            ht.Add("Location", "USA");
            ht.Add("Deptid", 1);
            //ht.Add()

            //Console.WriteLine(ht["Eid"]);
            //Console.WriteLine(ht["Ename"]);
            //Console.WriteLine(ht["Job"]);
            //Console.WriteLine(ht["Salary"]);
            //Console.WriteLine(ht["Phone Number"]);

            foreach (var key in ht.Keys)
            {
                //Console.WriteLine(key);
                Console.WriteLine(key + " : " + ht[key]);
            }
        }
    }
}
