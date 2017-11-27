using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_33
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double d;
            d = Double.Parse(a);
            double r;
            r = 6350;
            double result;
            result = Math.Sqrt(d * (2 * r + d));
            Console.WriteLine("{0:F4}", result);


        }
    }
}
