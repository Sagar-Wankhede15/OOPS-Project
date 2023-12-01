using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class First
    {
        public int x = 100;
        static void Main()
        {
            First f1 = new First();
            First f2 = f1;
            Console.WriteLine(f1.x + " " + f2.x);
            f1.x = 200;
            Console.WriteLine(f1.x + " " + f2.x);
            f2.x = 300;
            Console.WriteLine(f1.x + " " + f2.x);
            Console.ReadLine();

        }
    }
}
