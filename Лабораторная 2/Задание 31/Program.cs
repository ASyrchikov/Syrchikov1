using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_31
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            double y;
            y = 7 * Math.Pow(x, 2) - 3 * x + 6;
            Console.WriteLine(y);
        }
    }
}
