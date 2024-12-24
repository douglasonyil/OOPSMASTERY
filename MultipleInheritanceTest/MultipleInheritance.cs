namespace MultipleInheritanceTest
{
    interface IInterface1
    {
        void Test();
        void Show();
    }
    interface IInterface2
    {
        void Test();
        void Show();
    }
    internal class MultipleInheritance:IInterface1, IInterface2
    {
        void IInterface1.Show()
        {
            Console.WriteLine("Declared in IInterface1 and implemented in class");
        }
        void IInterface2.Show()
        {
            Console.WriteLine("Declared in IInterface2 and implemented in class");
        }
        public void Test()
        {
            Console.WriteLine("Interfaces methods implemented in child class");
        }
        static void Main(string[] args)
        {
            MultipleInheritance m = new MultipleInheritance();
            m.Test();
            IInterface1 i1 = m; i1.Show();
            IInterface2 i2 = m; i2.Show();
        }
    }
}
