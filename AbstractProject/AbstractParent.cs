namespace AbstractProject
{
    internal abstract class AbstractParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine( x+y );
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine( x-y );
        }
        public abstract void Mult(int x, int y);
        public abstract void Div(int x, int y);
    }
}
