using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_22
{
    class Program
    {
        static void Main(string[] args)
        {

            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x<=0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            double z = y * Math.PI / 180;
            double g = 9.8067;
            double result;
            result = x * g * Math.Cos(z);
            Console.WriteLine("{0:F6}", result);
        }
    }
}
