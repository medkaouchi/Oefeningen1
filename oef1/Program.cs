using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 5;
            Console.WriteLine(a.ToString()+" + "+b.ToString()+" = "+(a+b));
            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + (a-b));
            Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + (a * b));
            Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + (Convert.ToDouble(a) / b));

            Console.ReadLine();
        }
    }
}
