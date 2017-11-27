using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_32
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            x  = Console.ReadLine();
            double a;
            a = Double.Parse(x);
            double b;
            b = 12*Math.Pow(a,2)+7*a-16;
            Console.WriteLine("{0:F4}",b);
        }
    }
}
