namespace MulticastDelegates
{
    public delegate double RectangleDelegate(double Width,  double Height);
    internal class Rectangle
    {
        public double GetArea(double Width,  double Height)
        {
            return Width*Height;
        }
        public double GetPerimeter(double Width, double Height)
        {
            return 2*(Width+Height);
        }
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle();
            //r.GetArea(100.00, 50.00);
            //r.GetPerimeter(100.00, 50.00);
            RectangleDelegate rd = r.GetArea;
            rd += r.GetPerimeter;
            //rd.Invoke(100.00, 50.00);
            //Console.WriteLine("\n");
            //rd.Invoke(25.00, 100.00);

            Console.WriteLine(rd.Invoke(10.00, 50.00));
            Console.WriteLine("\n");
            Console.WriteLine(rd.Invoke(25.00, 100.00));
        }
    }
}
