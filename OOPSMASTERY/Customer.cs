namespace OOPSMASTERY
{
    public class Customer
    {
        int _Custid;
        bool _Status;
        string _Cname, _State;
        double _Balance;
        Cities _City;

        public Customer(int Custid, bool Status, string Cname, double Balance, Cities City, string State)
        {
            this._Custid = Custid;
            this._Status = Status;
            this._Cname = Cname;
            this._Balance = Balance;
            this._City = City;
            this._State = State;
          
        }

        public int Custid
        {
            get { return _Custid; }
            
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set 
            {
                if (_Status == true)
                {
                    _Cname = value;
                }
                
            }
        }
        public double Balance
        {
            get 
            {
                  return _Balance;               
            }
            set 
            {
                if (_Status == true)
                {
                    _Balance = value;
                }
            }
        } 
        public Cities City
        { 
            get { return _City; }
            set 
            {
                if (Status == true)
                {
                    _City = value;
                }
            }                
        }
        public string State
        {
            get { return _State; }
            protected set 
            { 
                if (Status == true)
                _State = value; 
            }
        }
        public string Country { get; } = "Kenya";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(123, false, "Douglas", 20000, Cities.Nairobi, "Califoria");
            Console.WriteLine("\nPrinting Customer Details Before Status Activated");
            int customerId = c.Custid;
            bool customerStatus = c.Status;
            string customerName = c.Cname;
            double customerBalance = c.Balance;
            Cities customerCity = c.City;
            string customerState = c.State;
            string customerCountry = c.Country;
            
            Console.WriteLine($"Customer Id :{customerId}");
            if (c.Status == true)
            {
                Console.WriteLine("Customer Status : Active");
            }
            else
            {
                Console.WriteLine("Customer Status : In Active");
            }
            Console.WriteLine($"Customer Name :{customerName}");
            Console.WriteLine($"Customer Account Balance :{customerBalance}");
            Console.WriteLine($"Customer City :{customerCity}");
            Console.WriteLine($"Customer State :{customerState}");
            Console.WriteLine($"Customer Country :{customerCountry}");
          
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            c.Status = true;
            c.Cname = customerName + " " + "Onyil"; // Assignment failed so below stmt prints old name
            c.Balance -= 5000; // Assignmet failed so below stmt prints old balance 
            c.City = Cities.Nakuru;
            //c.Country = "USA";
            //c.State = "Mumbai";  // Invalid because current class is not a child class of Customer

            Console.WriteLine("\nPrinting Customer Details After Status Turns True");
            Console.WriteLine("Customer Id :" + c.Custid);
            if (c.Status == true)
            {
                Console.WriteLine("Customer Status : Active");
            }
            else
            {
                Console.WriteLine("Customer Status : In Active");
            }
            Console.WriteLine("Modified Customer Name :" + c.Cname);
            Console.WriteLine("Customer Account Balance After Withdraw :" + c.Balance);
            Console.WriteLine("Customer's New City :" + c.City);
            Console.WriteLine("Customer's New State :" + c.State);
            Console.WriteLine("Customer's Country :" + c.Country);
        }
    }
}
