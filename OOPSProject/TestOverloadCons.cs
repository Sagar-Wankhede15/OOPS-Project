namespace OOPSProject
{
    class TestOverloadCons
    {
        int i; 
        bool b;
        public TestOverloadCons()
        {

        }
        public TestOverloadCons(int i)
        {
        this.i = i;
        }
        public TestOverloadCons(bool b)
        {
        this.b = b;
        }
        public TestOverloadCons(int i, bool b)
        {
            this.i = i;
            this.b = b;
        }
        public void Display()
        {
            Console.WriteLine($"Value of i is:{i} and value of bool is:{b}");
        }
        static void Main()
        {
            TestOverloadCons c1 = new TestOverloadCons();
            c1.Display();
            TestOverloadCons c2 = new TestOverloadCons(10);
            c2.Display();
            TestOverloadCons c3 = new TestOverloadCons(true);   
            c3.Display();
            TestOverloadCons c4 = new TestOverloadCons(10,true);   
            c4.Display();
            Console.ReadLine();
        }
    }
}