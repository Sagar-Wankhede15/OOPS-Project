namespace OOPSProject
{
    internal class CopyConDemo
    {
        int id;
        string Name;
        double Balance;
        public CopyConDemo(int id)
        {
            this.id = id;
            Name = "Sagar";
            Balance = 5000.00;
        }
        public CopyConDemo(CopyConDemo cd)
        {
            this.id = cd.id;
            Name = cd.Name;
            Balance = cd.Balance;
        }
        public void Display()
        {
            Console.WriteLine($"id:{id};Name:{Name};Balance:{Balance}");
        }
        static void Main()
        {
            CopyConDemo cd1 = new CopyConDemo(1005);
            cd1.Display();
            CopyConDemo cd2 = new CopyConDemo(cd1);
            cd2.Display();
            Console.WriteLine();
            cd1.Balance = 10000;
            cd1.Display();
            cd2.Display();
            Console.WriteLine();
            cd1.Balance = 20000;
            cd1.Display();
            cd2.Display();
            Console.ReadLine();
        }
    }
}