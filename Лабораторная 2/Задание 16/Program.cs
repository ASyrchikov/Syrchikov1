using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
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
            if (y <= 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            double result;
            result = -5 * Math.Sqrt(x + Math.Sqrt(y));
            if (result<=0)
                {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                    return;
            
            }
            Console.WriteLine("{0:F4}", result);
        }
    }
}
