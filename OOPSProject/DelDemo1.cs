using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class DelDemo1
    {
        public void AddNums(int x, int y, int z)
        {
            Console.WriteLine($"Sum of given 3 numbers is{x + y + z}");
        }
        public static string SayHello(string name)
        {
            return $"{name},Have a nice day!";
        }
        static void Main()
        {
            DelDemo1 obj = new DelDemo1();
            CalculatorDelegate cd1 = obj.AddNums;
            cd1(10, 20, 30); cd1(20,30,40); cd1(20,30,10);
            WishDelegate wd = DelDemo1.SayHello;
            Console.WriteLine(wd("Sagar"));
            Console.WriteLine(wd("Anoop"));
            Console.WriteLine(wd("Abhishek"));
            Console.ReadLine();

        }
    }
}
