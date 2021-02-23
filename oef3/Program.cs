using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal 1 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Getal 2 : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int res1 = a + b;
            int res2 = a - b;
            int res3 = a * b;
            double res4= Convert.ToDouble(a) / b;

            Console.WriteLine("{0} + {1} = {2}",a,b,res1);
            Console.WriteLine("{0} - {1} = {2}", a, b, res2);
            Console.WriteLine("{0} * {1} = {2}", a, b, res3);
            Console.WriteLine("{0} / {1} = {2}", a, b,(res4).ToString("0.##"));

            Console.WriteLine("{0} + {1} + {2} + {3} = {4}",res1,res2,res3, Math.Round(res4, 2), (res1 +res2+res3+res4).ToString("0.##"));
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", res1, res2, res3, Math.Round(res4, 2), (res1 * res2 * res3 * res4).ToString("0.##"));

            Console.ReadLine();
        }
    }
}
