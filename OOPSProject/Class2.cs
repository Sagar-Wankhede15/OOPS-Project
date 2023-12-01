using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class Class2:Class1
    {
        public Class2(int x):base(x)
        {
            Console.WriteLine("Class 2 constructor is called"+ "\t" + x);
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        public void Test4()
        {
            Console.WriteLine("Method 4");
        }
        static void Main()
        {
            Class2 c = new Class2(50);
            Class1 p = c;
            c.Test1();
            c.Test2();
            c.Test3();
            c.Test4();
            Console.ReadLine();
        }

    }
}
