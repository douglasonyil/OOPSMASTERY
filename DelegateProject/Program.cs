namespace DelegateProject
{
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str);
    internal class Program
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "Hello" + " " + name;
        }
        static void main(string[] args)
        {
            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(12, 13);

            SayDelegate sd = new SayDelegate(SayHello);
            string s = sd("Onyil");
            Console.WriteLine(s);
            //p.AddNums(1, 2);

            //string s = Program.SayHello("Douglas");
            //Console.WriteLine(s);
        }
    }
}
