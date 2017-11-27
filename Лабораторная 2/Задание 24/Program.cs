using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_24
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
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            if (y <= 0)
            {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            String c;
            c = Console.ReadLine();
            double z;
            z = Double.Parse(c);
            if (z <= 0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательной");
                return;
            }
            double g = 9.8067;
            double result;
            result = g * ((x * y) / Math.Pow(z, 2));
            Console.WriteLine("{0:F4}", result);
        }
    }
}


