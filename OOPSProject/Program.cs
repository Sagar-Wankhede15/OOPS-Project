using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace OOPSProject
{
    internal class Program
    {
        // Non value returning method without parameters
        public void Test1()
        {
            int x = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x}*{i}={x * i}");
            }
        }
        // Non-value returning method with parameters
        public void Test2(int x, int ub)
        {
            for (int i = 1; i <= ub; i++)
            {
                Console.WriteLine($"{x}*{i}={x * i}");
            }

        }
        // Value returning method without parameters
        public string Test3()
        {
            string str = "hello world";
            str = str.ToUpper();
            return str;
        }
        // value returning method with parameters
        public string Test4(string str)
        {
            str = str.ToUpper();
            return str;
        }
        static void Main()
        {
            Program p = new Program();
            // Calling non-value returning methods
            p.Test1();
            Console.WriteLine();    
            p.Test2(2,12);
            Console.WriteLine();
            // Calling value returning methods
            string s1 = p.Test3();
            Console.WriteLine(s1);
            Console.WriteLine();
            string s2 = p.Test4("Hello Sagar");
            Console.WriteLine(s2);
            Console.ReadLine();
       }
    }
}





