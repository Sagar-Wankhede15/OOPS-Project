using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class LoadParent
    {
        public void Test()
        {
            Console.WriteLine("Parent class method of Test is called");
        }
        public virtual void Show() //overridable
        {
            Console.WriteLine("Parent class method of Show is called");
        }
        public void Display()
        {
            Console.WriteLine("Parent class method of Display is called");
        }
    }
}
