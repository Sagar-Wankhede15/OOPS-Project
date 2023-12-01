using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class LoadChild : LoadParent
    {
        public void PShow()
        {
            base.Show();
        }
        public void PDisplay()
        {
            base.Display();
        }
        public void Test(int i)
        {
            Console.WriteLine("Child class Test method is called");
        }
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method Is Called.");
        }
        public new void Display()
        {
            Console.WriteLine("Child Class Display Method Is Called.");
        }
        static void Main()
        {   
             
            LoadChild c = new LoadChild();
            c.Test(); //Executes Parent class Test method
            c.PShow(); //Executes Parent class Show method
            c.PDisplay(); //Executes Parent class Display method
            c.Show();  //Execute child class show method
            c.Display(); //Execute child class Display method
            c.Test(100); //Execute child class Test method
            
            Console.ReadLine();
        }


    }
}
