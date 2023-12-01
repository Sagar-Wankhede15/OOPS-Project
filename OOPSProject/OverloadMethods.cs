using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class OverloadMethods
    {
        
        public void Show()
        {
            
            Console.WriteLine(1);
        }
        public void Show(int i)
        {
            Console.WriteLine(i);
        }
        public void Show(string s)
        {
            Console.WriteLine(s);
        }
        public void Show(int i,string s)
        {
            Console.WriteLine(i + s);
        }
        public void Show(string s,int i)
        {
            Console.WriteLine(s + i);
        }
        public static void Main(string[] args)
        {
            
            OverloadMethods obj = new OverloadMethods();
            obj.Show();
            obj.Show(100);
            obj.Show("Sagar");
            obj.Show(100,"Sagar");
            obj.Show("Sagar",100);
            
            Console.ReadLine();
        }
    }
}
