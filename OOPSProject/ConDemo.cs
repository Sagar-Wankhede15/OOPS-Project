using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class ConDemo
    {
        public ConDemo() //Explicit Constructor
        {
            Console.WriteLine("Constructor is called:");
        }
        public void Demo() //Method
        {
            Console.WriteLine("Method is called:");
        }
        static void Main(string[] args) 
        {
            ConDemo cd1 = new ConDemo();
            ConDemo cd2 = new ConDemo();
            ConDemo cd3 = cd2;
            cd1.Demo();
            cd2.Demo();
            cd3.Demo();
            Console.ReadLine();

        }


    }
}
