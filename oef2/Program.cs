using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal 1 : ");  
            int a =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Getal 2 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + (a + b));
            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + (a - b));
            Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + (a * b));
            Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + (Convert.ToDouble(a) / b));

            Console.ReadLine();
        }
    }
    
}
