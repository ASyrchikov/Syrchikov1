using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            double z = x * Math.PI / 180;
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            double f;
            f = y * Math.PI / 180;
            double result;
            result = Math.Sin(z) * Math.Cos(f) + Math.Cos(z) * Math.Sin(f);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
