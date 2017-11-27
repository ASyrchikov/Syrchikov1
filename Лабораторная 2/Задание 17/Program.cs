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
            if (x<0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            if (y<0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            string c;
            c = Console.ReadLine();
            double d;
            d = Double.Parse(c);
            double result;
            result = d/ (x + y);
            Console.WriteLine("{0:F4}", result);



        }
    }
}
