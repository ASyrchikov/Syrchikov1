using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x == 0)
            {
                Console.WriteLine("Значение x должно быть не равно нулю");
                return;
            }
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            string c;
            c = Console.ReadLine();
            double f;
            f = Double.Parse(c);
            string d;
            d = Console.ReadLine();
            double z;
            z = Double.Parse(d);
            if (z == 0)
            {
                Console.WriteLine("Значение z должно быть не равно нулю");
                return;
            }
            double result;
            result = ((x * z) + (y * f)) / (x * z);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
