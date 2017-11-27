using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
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
                Console.WriteLine("Значение x должно быть положительным");
                return;
            }
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            if (y < 0)
            {
                Console.WriteLine("Значение y должно быть положительным");
                return;
            }
            String c;
            c = Console.ReadLine();
            double z;
            z = Double.Parse(c);
            if (z <= 0)
            {
                Console.WriteLine("Значение z должно быть неотрицательным");
                return;
            }
            double g = 9.8067;
            double result;
            result = x * Math.Pow(y, 2) / 2;
            Console.WriteLine("Кинетическая энергия составляет: {0:F4} Дж", result);
            double result2;
            result2 = x * g * z;
            Console.WriteLine("Потенциальная энергия составляет: {0:F4} Дж", result2);



        }
    }
}
