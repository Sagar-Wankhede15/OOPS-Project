namespace OOPSProject
{
    internal class AbsChild : AbsParent
    {
        public override void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public override void Div(int a, int b)

        {
            Console.WriteLine(a / b);
        }
        public void Mod(int a, int b)
        {
            Console.WriteLine(a % b);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            AbsParent p = c;
            p.Add(100, 60); p.Add(75, 17);
            p.Mul(12, 13); p.Div(870, 15);
            Console.ReadLine();
        }
    }
}
