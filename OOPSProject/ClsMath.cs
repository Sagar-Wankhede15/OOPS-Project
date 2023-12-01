using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class ClsMath:Program,IMath1,IMath2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main()
        {
            ClsMath obj = new ClsMath();
            IMath1 i1 = obj; IMath2 i2 = obj;
            i1.Add(100, 34); i1.Sub(576, 287);
            i2.Mul(12, 38); i2.Div(456, 2);
            Console.ReadLine();
        }
    }
}
