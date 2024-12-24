using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProjects
{
    internal class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    class TestCustomer
    {
        static void Main(string[] args)
        {
            List<Customer> custlist = new List<Customer>();
            Customer c1 = new Customer { Custid = 101, Name = "Foo", City = "Kisumu", Balance = 2500.00 };
            Customer c2 = new Customer { Custid = 102, Name = "Oloor", City = "Nairobi", Balance = 3500.00 };
            Customer c3 = new Customer { Custid = 103, Name = "Onyilo", City = "Mombasa", Balance = 5500.00 };
            Customer c4 = new Customer { Custid = 104, Name = "Douglas", City = "Nakuru", Balance = 4500.00 };

            custlist.Add(c1);custlist.Add(c2);custlist.Add(c3);custlist.Add(c4);

            foreach (Customer c in custlist)
            {
                Console.WriteLine(c.Custid + " " + c.Name + " " + c.City + " " + c.Balance);
            }
        }
    }
}
