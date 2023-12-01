using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPSProject
{
    internal class Methods
    {
        int x = 200;
        static int y = 100;
        public void Add()
        {
            Console.WriteLine(x + y);
        }
        public static void Sub()
        {
            Methods m = new Methods();
            Console.WriteLine(m.x - y);
        }
    }
    internal class TestMethods
    {
        static void Main()
        {
            Methods obj = new Methods();
            obj.Add(); //Add is non-static so calling it with instance
            Methods.Sub(); //Sub is static so calling it with class name
            Console.ReadLine();
        }
    }
}


