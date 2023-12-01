using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class TestProgram
    {
        public void CallMethods()
        {
            Program p = new Program();
            p.Test1();
            Console.WriteLine();
            p.Test2(2,10);
            Console.WriteLine();
            Console.WriteLine(p.Test3());
            Console.WriteLine();
            Console.WriteLine(p.Test4("hello india"));
        }
        static void Main(string[] args)
        {
           new TestProgram().CallMethods();
            Console.ReadLine();
        }
    }
}
