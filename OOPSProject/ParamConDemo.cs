using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class ParamConDemo
    {
        public ParamConDemo(int i)
        {
            Console.WriteLine($"Parameterized Constructor is called:{i}");
        }
        static void Main(string[] args) 
        {
            ParamConDemo conDemo1 = new ParamConDemo(100);
            ParamConDemo conDemo2 = new ParamConDemo(200);
            ParamConDemo conDemo3 = new ParamConDemo(300);
            Console.ReadLine();

        }

    }
}
