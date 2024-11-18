namespace AbstractImplementation
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;

        public abstract double GetArea();
    }
    public class Rectangle:Figure
    {
        public Rectangle(double Width,  double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width*Height;
        }
    }
    public class Circle:Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {

            return Pi*Radius*Radius;
        }
    }
    public class Cone:Figure
    {
        public Cone(double Radius, double Height)
        {  
           this.Radius = Radius;
           this.Height = Height;        
        }

        public override double GetArea()
        {
            return Pi*Radius*(Radius+Math.Sqrt(Height*Height+Radius*Radius));
        }
    }
    class TestFigures
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10.0, 5.0);
            Circle c = new Circle(7.0);
            Cone cn = new Cone(7.0, 5.0);

            Console.WriteLine("Print The Area Of Figures");
            Console.WriteLine("\nArea Of The Rectangle : " + r.GetArea());
            Console.WriteLine("Area Of The Circle : " + c.GetArea());
            Console.WriteLine("Area Of The Cone : " + cn.GetArea());
        }
    }
}
