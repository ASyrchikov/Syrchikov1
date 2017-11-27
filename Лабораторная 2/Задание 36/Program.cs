using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_36
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            string c;
            c = Console.ReadLine();
            double z;
            z = Double.Parse(c);
            string d;
            d = Console.ReadLine();
            double w;
            w = Double.Parse(d);
            double result;
            result = Math.Sqrt(Math.Pow(z - x, 2) + Math.Pow(w - y, 2));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
