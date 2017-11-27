using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x<0)
                {
                Console.WriteLine("Начальная скорость должно быть неотрицательна");
                return;
            }
            String b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            if (y <= 0)
            {
                Console.WriteLine("Время должно быть положительным");
                return;
            }
            String c;
            c = Console.ReadLine();
            double d;
            d = Double.Parse(c);
            String e;
            double result;
            result = x * y + (d * Math.Pow(y, 2) / 2);
            Console.WriteLine("{0:F4}", result);


        }
    }
}
