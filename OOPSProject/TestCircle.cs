using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class TestCircle
    {
        static void Main()
        {
            Circle c = new Circle();
            double Radius = c.Radius;
            c.Radius = 15.00;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
