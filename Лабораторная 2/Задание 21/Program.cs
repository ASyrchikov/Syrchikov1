using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_21
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
            if (y == 0)
            {
                Console.WriteLine("Значение y должно быть не равно нулю");
                return;
            }
            double result;
            result = (1 / x) + (1 / y);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
