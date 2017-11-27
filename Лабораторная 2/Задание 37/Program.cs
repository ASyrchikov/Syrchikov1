using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_37
{
    class Program
    {
        static void Main(string[] args)
        {

            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x <= 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
                string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            String c;
            c = Console.ReadLine();
            double z;
            z = Double.Parse(c);
            if (z <= 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
            string d;
            d = Console.ReadLine();
            double w;
            w = Double.Parse(d);
            double result;
            result = x + z;
            Console.WriteLine("volume {0:F4}", result);
            double result2;
            result2 = (y*x+w*z)/(x+z);
            Console.WriteLine("temperature {0:F4}", result2);
        }
    }
}
