using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            

            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            if (x == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            string c;
            c = Console.ReadLine();
            double z;
            z = Double.Parse(c);
            if (x == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            string d;
            d = Console.ReadLine();
            double f;
            f = Double.Parse(d);
             if (x == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            double result;
            result = 1 / Math.Sqrt((x * Math.Pow(f, 2)) + (y * f) + z);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
