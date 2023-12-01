namespace OOPSProject
{
    internal abstract class AbsParent
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public abstract void Mul(int a, int b);
        public abstract void Div(int a, int b);
    }
}
